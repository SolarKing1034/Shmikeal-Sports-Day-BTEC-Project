using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTEC_Project
{
    public partial class AdminLoginArea : Form
    {
        public AdminLoginArea()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new MainMenu();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnExitSys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidatePass_Click(object sender, EventArgs e)
        {
            string userpass = txtPassword.Text;
            string currentpass = "password1";

            if (userpass == currentpass)
            {
                loggedin.alrloggedins = true;
                MessageBox.Show("Login Successful!");
                this.Hide();
                var opencustform = new AdminArea();
                opencustform.Closed += (s, args) => this.Close();
                opencustform.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password! Try Again!");
                txtPassword.Clear();
            }
            
        }
        private void ClickedOnEye(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        private void ClickedOffEye(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void AdminLoginArea_Load_1(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
            ShowOrHide.MouseDown += new MouseEventHandler(ClickedOnEye);
            ShowOrHide.MouseUp += new MouseEventHandler(ClickedOffEye);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
     }
}
