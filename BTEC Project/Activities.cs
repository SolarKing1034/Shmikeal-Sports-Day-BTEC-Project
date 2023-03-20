using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTEC_Project
{
    public partial class Activities : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public Activities()
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

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndisplayActivities_Click(object sender, EventArgs e)
        {
            lboxEvents.Items.Clear();
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareadert;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblActivities ORDER BY TblActivities.activity_id";
                sqlite_datareadert = sqlite_cmd.ExecuteReader();
                while (sqlite_datareadert.Read())
                {
                    int ACTIVITYNAME = sqlite_datareadert.GetInt32(0);
                    string ACTIVITYDESC = sqlite_datareadert.GetString(1);
                    string activitytype = sqlite_datareadert.GetString(2);
                    lboxEvents.Items.Add(ACTIVITYNAME + ", " + ACTIVITYDESC + ", " + activitytype);
                }
                sqlite_datareadert.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnnewActivities_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            try
            {
                sqlite_conn.Open();
                //MessageBox.Show("Database Open")
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                SQLiteDataReader sqlite_datareaderz;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblActivities WHERE activity_id = @activityid;";
                sqlite_cmd.Parameters.AddWithValue("@activityid", txtActivitiesID.Text);
                sqlite_datareaderz = sqlite_cmd.ExecuteReader();
                while (sqlite_datareaderz.Read())
                {
                    int ITEMIDCODECOMPARISON = sqlite_datareaderz.GetInt32(0);
                    int activtyidint = Convert.ToInt32(txtActivitiesID.Text);

                    if (ITEMIDCODECOMPARISON == activtyidint)
                    {
                        MessageBox.Show("Activity with the ID code " + ITEMIDCODECOMPARISON + " already Exists. Please enter a different ID or edit the existing item");
                        txtActivitiesID.Clear();
                        txtActivitiesDesc.Clear();
                        TextActivityType.Text = " ";
                        
                    }
                }
                sqlite_datareaderz.Close();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO TbLActivities(activity_id, activity_desc, activity_type) VALUES(@activity_id, @activity_desc, @activity_type); ";
                sqlite_cmd.Parameters.AddWithValue("@activity_id", txtActivitiesID.Text);
                sqlite_cmd.Parameters.AddWithValue("@activity_desc", txtActivitiesDesc.Text);
                sqlite_cmd.Parameters.AddWithValue("@activity_type", TextActivityType.Text);



                if (txtActivitiesID.Text == "")
                {
                    throw new ArgumentNullException("Activity ID has been left empty!");
                }
                if (txtActivitiesDesc.Text == "")
                {
                    throw new ArgumentNullException("Activity Description has been left empty!");
                }
                if(TextActivityType.Text == "")
                {
                    throw new ArgumentNullException("Activity Tyoe has been left empty!");
                }
                else
                {
                    SQLiteDataReader sqlite_datareader;
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    MessageBox.Show("Activity Added!");
                    txtActivitiesID.Clear();
                    txtActivitiesDesc.Clear();
                    TextActivityType.Text = " ";


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btndeleteActivities_Click(object sender, EventArgs e)
        {

            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            SQLiteDataReader sqlite_datareader;

            try
            {
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM TblActivities WHERE activity_ID = @ItemIDCode";
                sqlite_cmd.Parameters.AddWithValue("@ItemIDCode", txtActivitiesID.Text);
                if (txtActivitiesID.Text == "")
                {
                    MessageBox.Show("No ID has been entered");
                }
                else
                {
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    sqlite_conn.Close();
                    MessageBox.Show("Record Deleted!");
                    lboxEvents.Update();
                    txtActivitiesID.Clear();
                    txtActivitiesDesc.Clear();
                    TextActivityType.Text = " ";
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnupdateActivities_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            SQLiteDataReader sqlite_datareader;
            sqlite_conn.Open();


            sqlite_cmd = sqlite_conn.CreateCommand(); 
            sqlite_cmd.CommandText = "Update TblActivities SET activity_desc = @Dasc SET activity_type = @activity_type WHERE activity_id =@ActivityID"; 
            sqlite_cmd.Parameters.AddWithValue("@ActivityID", txtActivitiesID.Text);
            sqlite_cmd.Parameters.AddWithValue("@activity_type", TextActivityType.Text);

            sqlite_cmd.Parameters.AddWithValue("@Dasc", txtActivitiesDesc.Text);
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            sqlite_datareader.Close();
            MessageBox.Show("Record Updated");
            txtActivitiesID.Clear();
            txtActivitiesDesc.Clear();
            TextActivityType.Text = " ";
        }

        private void btnSearchActivities_Click_1(object sender, EventArgs e)
        {
            lboxEvents.Items.Clear(); 
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            SQLiteDataReader sqlite_datareader;
            sqlite_conn.Open();


            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM TblActivities WHERE activity_id=@ActivityID OR activity_desc=@Dasc ORDER BY TblActivities.activity_id";
            sqlite_cmd.Parameters.AddWithValue("@ActivityID", txtActivitiesID.Text);
            sqlite_cmd.Parameters.AddWithValue("@Dasc", txtActivitiesDesc.Text);
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int ActivityID = sqlite_datareader.GetInt32(0);
                string Dasc = sqlite_datareader.GetString(1);
                lboxEvents.Items.Add(ActivityID + ", " + Dasc);
            }
            sqlite_datareader.Close();

            txtActivitiesID.Clear();
            txtActivitiesDesc.Clear();
            TextActivityType.Text = " ";
        }
        private void btnsearchActivities_Click(object sender, EventArgs e)
        {

        }
        private void Activities_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
