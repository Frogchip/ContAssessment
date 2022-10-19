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
    public partial class hard : Form
    {
        int score = 0;
        int life = 0;
        int timeLeft = 0;
        string[] linesArray;
        string[] questionPartsArray;
        string rbselected;
        public hard()
        {
            InitializeComponent();
        }

        private void hard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            linesArray = File.ReadAllLines("QuizQuestionsHard.txt");
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

        private void label2_Click(object sender, EventArgs e)
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
                timer1.Stop();
                MessageBox.Show("Incorrect!");
                life = life + 1;
                if (life == 3)
                {
                    endscreen end1 = new endscreen();
                    this.Hide();
                    end1.Show();
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Good job!");
                score = score + 1;
                hard H1 = new hard();
                this.Hide();
                H1.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "1";
        }

        private void lblans3_Click(object sender, EventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "2";
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
            timeLeft = timeLeft - 1;
            lblTime.Text = timeLeft + "";
            if (timeLeft == 0)
            {
                lblTime.Visible = false;
                MessageBox.Show("Out of time!");
                easyRB E1 = new easyRB();
                this.Hide();
                E1.Show();
                life = life + 1;
                if (life == 3)
                {
                    endscreen end1 = new endscreen();
                    end1.Show();
                }
            }
        }
    }
}
