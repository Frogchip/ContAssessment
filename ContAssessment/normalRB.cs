using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContAssessment
{
    public partial class normalRB : Form
    {
        string[] linesArray;
        string[] questionPartsArray;
        string rbselected;
        public normalRB()
        {
            InitializeComponent();
        }

        private void normal_Load(object sender, EventArgs e)
        {
            globaldata.NTimeLeft = 13;
            lblTime.Visible = true;
            timer1.Start();
            //linesArray = File.ReadAllLines("QuizQuestionsNormal.txt");
           // Random rand = new Random();
           // int qcount = linesArray.Count();
           // int num = rand.Next(0, qcount);
           // questionPartsArray = linesArray[num].Split(',');
            lblQuestion.Text = questionPartsArray[1];
            lblans1.Text = questionPartsArray[2];
            lblans2.Text = questionPartsArray[3];
            lblans3.Text = questionPartsArray[4];
            lblans4.Text = questionPartsArray[5];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Kick out if they haven't selected an answer yet.

            if (!rb1.Checked && !rb2.Checked && !rb3.Checked && !rb4.Checked)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }
            // Logic to work out if they selected the correct answer
            if (rbselected != questionPartsArray[6])
            {
                MessageBox.Show("Incorrect!");
                globaldata.NLife = globaldata.NLife + 1;
                if (globaldata.NLife == 3)
                {
                    endscreen end1 = new endscreen();
                    this.Hide();
                    end1.Show();
                }
            }
            else
            {
                timer1.Stop();
                lblTime.Visible = false;
                MessageBox.Show("Good job!");
                
                
               
                }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "2";
        }

        private void lblans3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "1";
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "3";
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "4";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            globaldata.NTimeLeft = globaldata.NTimeLeft - 1;
            lblTime.Text = globaldata.NTimeLeft + "";
            if (globaldata.NTimeLeft == 0)
            {
                timer1.Stop();
                lblTime.Visible = false;
                MessageBox.Show("Out of time!");
                normalRB N1 = new normalRB();
                this.Hide();
                N1.Show();
                globaldata.NLife = globaldata.NLife + 1;
                if (globaldata.NLife == 3)
                {
                    endscreen end1 = new endscreen();
                    end1.Show();
                }
            }
        }
    }
}
