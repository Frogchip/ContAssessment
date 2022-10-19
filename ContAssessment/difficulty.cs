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
    public partial class difficulty : Form
    {
        public difficulty()
        {
            InitializeComponent();
            lblnocheck.Visible = false;
        }

        private void cbEasy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbHard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbEasy.Checked == false || cbNormal.Checked == false || cbHard.Checked == false)
            {
                lblnocheck.Visible = true;
            }
            if (cbEasy.Checked == true)
            {
                var linesarray = File.ReadAllLines("QuizQuestionsEasy.txt");
                Random rand = new Random();

                string[] random = linesarray.OrderBy(x => rand.Next()).ToArray();

                globaldata.EQCount = 10;

                for (int i = 0; i < globaldata.EQCount; i++)
                {
                    easyRB RB1 = new easyRB();
                    RB1.ShowQuestion(random[i]);
                    this.Hide();
                    RB1.ShowDialog();
                    globaldata.ETimeLeft = 16;
                    globaldata.Score += 1;
                }
                endscreen end1 = new endscreen();
                this.Hide();
                end1.ShowDialog();

            }
            if (cbNormal.Checked == true)
            {
                lblnocheck.Hide();
                normalRB N1 = new normalRB();
                this.Hide();
                N1.Show();
            }
            if (cbHard.Checked == true)
            {
                lblnocheck.Hide();
                hard H1 = new hard();
                this.Hide();
                H1.Show();
            }
        }
        private void difficulty_Load(object sender, EventArgs e)
        {

        }

        private void cbEasy_Click(object sender, EventArgs e)
        {
            cbEasy.Checked = true;
            cbNormal.Checked = false;
            cbHard.Checked = false;
            lblnocheck.Visible = false;

            lblRules.Text = "5 Lives\n" + "10 seconds\n";
        }        

        private void cbNormal_Click(object sender, EventArgs e)
        {
            cbEasy.Checked = false;
            cbNormal.Checked = true;
            cbHard.Checked = false;
            lblnocheck.Visible = false;

            lblRules.Text = "3 Lives\n" + "8 seconds\n";
        }

        private void cbHard_Click(object sender, EventArgs e)
        {
            cbEasy.Checked = false;
            cbNormal.Checked = false;
            cbHard.Checked = true;
            lblnocheck.Visible = false;

            lblRules.Text = "2 Lives\n" + "5 seconds\n";
        }
    }
}
