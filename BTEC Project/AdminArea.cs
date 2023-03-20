using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace BTEC_Project
{
    public partial class AdminArea : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public AdminArea()
        {
            InitializeComponent();
        }

        private void btnDBDelete_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");

            DialogResult YesOrNo = MessageBox.Show("Are You Sure? Database cannot be restored", "Deletion Confirmation", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                using (sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;"))
                {
                    using (SQLiteCommand sqlite_cmd = new SQLiteCommand("DROP DATABASE (ProjectDB)", sqlite_conn))
                    {
                        try
                        {
                            sqlite_conn.Open();
                            int returnValue = sqlite_cmd.ExecuteNonQuery();
                            sqlite_conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());

                        }
                    }
                }
            }
            else if (YesOrNo == DialogResult.No)
            {
                this.Refresh();
            }
        }
        private static void backup(string strDestination)
        {
            using (var location = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;"))
            using (var destination = new SQLiteConnection(string.Format(@"Data Source={0}:\ProjectDBBackup.db; Version=3;", strDestination)))
            {
                location.Open();
                destination.Open();
                location.BackupDatabase(destination, "main", "main", -1, null, 0);
            }
        }


        private void btnDBBackup_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            DateTime now = DateTime.Now;
            string cmd = ".backup";
            string filename = "ProjectDBBackup.db";
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "sqlite3" + "ProjectDB.db.backup ProjectDBBackup";
            sqlite_cmd.ExecuteNonQuery();
            MessageBox.Show("Database Backup Created");

        }


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new MainMenu();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnExisSys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminArea_Load(object sender, EventArgs e)
        {

        }
    }
}
