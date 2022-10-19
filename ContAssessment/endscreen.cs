using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContAssessment
{
    public partial class endscreen : Form
    {
        public endscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLead_Click(object sender, EventArgs e)
        {
            leaderboard lead1 = new leaderboard();
            this.Hide();
            lead1.Show();
        }

        private void endscreen_Load(object sender, EventArgs e)
        {
            lblScore.Text = globaldata.Score + "";
        }
    }
}
