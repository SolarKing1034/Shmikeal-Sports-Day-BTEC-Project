using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTEC_Project
{



    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        class GoNext
        {

        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLeaderboardsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new Leaderboards();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new Competitors();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnEventsTimesForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new EventsTimetable();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnActivityForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new Activities();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnAdminForm_Click(object sender, EventArgs e)
        {
            if (loggedin.alrloggedins == true)
            {
                this.Hide();
                var opencustforms = new AdminArea();
                opencustforms.Closed += (s, args) => this.Close();
                opencustforms.Show();
            }
            else
            {
                this.Hide();
                var opencustform = new AdminLoginArea();
                opencustform.Closed += (s, args) => this.Close();
                opencustform.Show();
            }

        }

        private void btnExitSys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
