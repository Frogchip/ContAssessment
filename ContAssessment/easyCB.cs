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
    public partial class easyCB : Form
    {
        string[] linesArray;
        string[] questionPartsArray;
        string cbselected;
        public easyCB()
        {
            InitializeComponent();
        }

        private void easyCB_Load(object sender, EventArgs e)
        {
            lblTime.Visible = true;
            timer1.Start();
            linesArray = File.ReadAllLines("QuizQuestionsEasy.txt");
            Random rand = new Random();
            int qcount = linesArray.Count();
            int num = rand.Next(0, qcount);
            questionPartsArray = linesArray[num].Split(',');
            lblQuestion.Text = questionPartsArray[1];
            lblans1.Text = questionPartsArray[2];
            lblans2.Text = questionPartsArray[3];
            lblans3.Text = questionPartsArray[4];
            lblans4.Text = questionPartsArray[5];
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            cbselected = "1";
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            cbselected = "2";
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            cbselected = "3";
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            cbselected = "4";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!cb1.Checked && !cb2.Checked && !cb3.Checked && !cb4.Checked)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }
            // Logic to work out if they selected the correct answer
            if (cbselected != questionPartsArray[6])
            {
                lblTime.Visible = false;
                MessageBox.Show("Incorrect!");
                globaldata.ELife = globaldata.ELife + 1;
                if (globaldata.ELife == 3)
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
                easyRB E1 = new easyRB();
                this.Hide();
                E1.Show();
                globaldata.Score = globaldata.Score + 1;
                if (globaldata.ELife == 3)
                {
                    endscreen end1 = new endscreen();
                    end1.Show();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            globaldata.ETimeLeft = globaldata.ETimeLeft - 1;
            lblTime.Text = globaldata.ETimeLeft + "";
            if (globaldata.ETimeLeft == 0)
            {
                lblTime.Visible = false;
                MessageBox.Show("Out of time!");
                easyRB E1 = new easyRB();
                this.Hide();
                E1.Show();
                globaldata.ELife = globaldata.ELife + 1;
                if (globaldata.ELife == 3)
                {
                    timer1.Stop();
                    endscreen end1 = new endscreen();
                    end1.Show();
                }
            }
        }
    }
}
