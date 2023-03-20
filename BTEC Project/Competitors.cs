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
    public partial class Competitors : Form
    {

        

        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public Competitors()
        {
            InitializeComponent();
        }

        
            
        

        

        private void button2_Click(object sender, EventArgs e)
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
                lboxComps.Items.Clear();
                SQLiteDataReader sqlite_datareader;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblCompetitor WHERE comp_id = @compid OR forename = @forename OR surname = @surname OR team_type = @TeamType OR events_participating_in = @eventspart";
                sqlite_cmd.Parameters.AddWithValue("@compid", txtCompID.Text);
                sqlite_cmd.Parameters.AddWithValue("@forename", txtCompForename.Text);
                sqlite_cmd.Parameters.AddWithValue("@surname", txtCompSurname.Text);
                sqlite_cmd.Parameters.AddWithValue("@TeamType", txtCompTeam.Text);
                sqlite_cmd.Parameters.AddWithValue("@eventspart", txtteamorindv.Text);

                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    int COMPID = sqlite_datareader.GetInt32(0);
                    string COMPFORE = sqlite_datareader.GetString(1);
                    string COMPSUR = sqlite_datareader.GetString(2);
                    string COMPTEAMTYPE = sqlite_datareader.GetString(3);
                    string COMPEVENTSPAR = sqlite_datareader.GetString(4);
                    int COMPPOINTS = sqlite_datareader.GetInt32(5);
                    lboxComps.Items.Add(COMPID + ", " + COMPFORE + ", " + COMPSUR + ", " + COMPTEAMTYPE + ", " + COMPEVENTSPAR + ", " + COMPPOINTS);
                    txtCompID.Clear();
                    txtCompForename.Clear();
                    txtCompSurname.Clear();
                    txtCompTeam.Text = "";
                    txtteamorindv.Text = "";
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
                sqlite_cmd.CommandText = "SELECT * FROM TblCompetitor WHERE comp_id = @compid;";
                sqlite_cmd.Parameters.AddWithValue("@compid", txtCompID.Text);
                sqlite_datareaderz = sqlite_cmd.ExecuteReader();
                while (sqlite_datareaderz.Read())
                {
                    int ITEMIDCODECOMPARISON = sqlite_datareaderz.GetInt32(0);
                    int txtCompIDint = Convert.ToInt32(txtCompID.Text);

                    if (ITEMIDCODECOMPARISON == txtCompIDint)
                    {
                        MessageBox.Show("Activity with the ID code " + ITEMIDCODECOMPARISON + " already Exists. Please enter a different ID or edit the existing item");
                        txtCompID.Clear();
                        txtCompForename.Clear();
                        txtCompSurname.Clear();
                        txtCompTeam.Text = "";
                        txtteamorindv.Text = "";
                    }
                }
                sqlite_datareaderz.Close();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO TblCompetitor(comp_id,forename,surname,team_type,events_participating_in,total_points) VALUES(@comp_id, @forename,@surname,@teamtype,@eventspartin,@points); ";
                sqlite_cmd.Parameters.AddWithValue("@comp_id", txtCompID.Text);
                sqlite_cmd.Parameters.AddWithValue("@forename", txtCompForename.Text);
                sqlite_cmd.Parameters.AddWithValue("@surname", txtCompSurname.Text);
                sqlite_cmd.Parameters.AddWithValue("@teamtype", txtCompTeam.Text);
                sqlite_cmd.Parameters.AddWithValue("@eventspartin", txtteamorindv.Text);
                sqlite_cmd.Parameters.AddWithValue("@points", 0);



                if (txtCompID.Text == "" || txtCompForename.Text == "" || txtCompSurname.Text == "" || txtCompTeam.Text == "" || txtteamorindv.Text == "")
                {
                    MessageBox.Show("A field has been left empty. All fields must be filled before adding a record");
                }
                else
                {
                    SQLiteDataReader sqlite_datareader;
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    MessageBox.Show("New Competitor Added!");
                    txtCompID.Clear();
                    txtCompForename.Clear();
                    txtCompSurname.Clear();
                    txtCompTeam.Text = "";
                    txtteamorindv.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            SQLiteDataReader sqlite_datareader;
            sqlite_conn.Open();


            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Update TblCompetitor SET forename = @Forename, surname = @Surname, team_type = @Team, events_participating_in = @Participating  WHERE comp_id =@CompID";
            sqlite_cmd.Parameters.AddWithValue("@CompID", txtCompID.Text);
            sqlite_cmd.Parameters.AddWithValue("@Forename", txtCompForename.Text);
            sqlite_cmd.Parameters.AddWithValue("@Surname", txtCompSurname.Text);
            sqlite_cmd.Parameters.AddWithValue("@Team", txtCompTeam.Text);
            sqlite_cmd.Parameters.AddWithValue("@Participating", txtteamorindv.Text);

            if (txtCompID.Text == ""|| txtCompForename.Text == ""|| txtCompSurname.Text == ""|| txtCompTeam.Text == ""|| txtteamorindv.Text == "")
            {
                MessageBox.Show("A field has been left empty. All fields must be filled before updating a record");
            }
            else
            {

                sqlite_datareader = sqlite_cmd.ExecuteReader();
                sqlite_datareader.Close();
                MessageBox.Show("Done");
                txtCompID.Clear();
                txtCompForename.Clear();
                txtCompSurname.Clear();
                txtCompTeam.Text = "";
                txtteamorindv.Text = "";
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            SQLiteDataReader sqlite_datareader;

            try
            {
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM TblCompetitor WHERE comp_id = @compid";
                sqlite_cmd.Parameters.AddWithValue("@compid", txtCompID.Text);
                if (txtCompID.Text == "")
                {
                    MessageBox.Show("No ID has been entered");
                }
                else
                {
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    sqlite_conn.Close();
                    MessageBox.Show("Record Deleted!");
                    lboxComps.Update();
                    txtCompID.Clear();
                    txtCompForename.Clear();
                    txtCompSurname.Clear();
                    txtCompTeam.Text = "";
                    txtteamorindv.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void btndisplaycomps_Click(object sender, EventArgs e)
        {
            lboxComps.Items.Clear();

            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareader;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblCompetitor ORDER BY TblCompetitor.comp_id";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    int COMPID = sqlite_datareader.GetInt32(0);
                    string COMPFORE = sqlite_datareader.GetString(1);
                    string COMPSUR = sqlite_datareader.GetString(2);
                    string COMPTEAMTYPE = sqlite_datareader.GetString(3);
                    string COMPEVENTSPAR = sqlite_datareader.GetString(4);
                    int COMPPOINTS = sqlite_datareader.GetInt32(5);
                    lboxComps.Items.Add(COMPID + ", " + COMPFORE + ", " + COMPSUR + ", " + COMPTEAMTYPE + ", " + COMPEVENTSPAR + ", " + COMPPOINTS);
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtteamorindv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Competitors_Load(object sender, EventArgs e)
        {


        }
    }
}
