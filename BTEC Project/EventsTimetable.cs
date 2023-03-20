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
    public partial class EventsTimetable : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public EventsTimetable()
        {
            InitializeComponent();
        }

        public void SQOptimial(object sender, EventArgs e)
        {
            sqlite_cmd.Parameters.AddWithValue("@eventid", txtEvent.Text);
            sqlite_cmd.Parameters.AddWithValue("@compid", txtCompID.Text);
            sqlite_cmd.Parameters.AddWithValue("@tactivityid", txtActivityID.Text);
            sqlite_cmd.Parameters.AddWithValue("@Participating", txteventtypeid.Text);
            sqlite_cmd.Parameters.AddWithValue("@rank", txtRank.Text);
            sqlite_cmd.Parameters.AddWithValue("@date", txtDate.Text);
        }

        string output = "{0,-20}\t{1,-20}\t{2,-20}\t{3,-20}\t{4,-20}\t{5,-20}";
        private void btndisplayevents_Click(object sender, EventArgs e)
        {
            lboxEvents.Items.Clear();
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            try
            {
                lboxEvents.Items.Add(string.Format(output, "Event ID", "Comp ID", "Activity ID", "Event Type ID", "Rank", "Event Date"));

                SQLiteDataReader sqlite_datareadert;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT TblEvents.event_id, TblEvents.event_date, TblEvents.comp_id, TblEvents.activity_id, TblEvents.rank_id, TblEvents.event_type_id," +
                   "TblCompetitor.comp_id, TblCompetitor.forename, TblCompetitor.surname, TblCompetitor.team_type," +
                   "TblActivities.activity_id, TblActivities.activity_desc," +
                   "TblPointsAwarded.rank, TblPointsAwarded.points_worth " +
                   "FROM TblEvents " +
                   "INNER JOIN TblCompetitor on TblEvents.comp_id = TblCompetitor.comp_id " +
                   "INNER JOIN TblActivities on TblEvents.activity_id = TblActivities.activity_id " +
                   "INNER JOIN TblPointsAwarded on TblEvents.rank_id = TblPointsAwarded.rank " +
                   "ORDER BY TblEvents.event_id";
                sqlite_datareadert = sqlite_cmd.ExecuteReader();


                while (sqlite_datareadert.Read())
                {
                    int EVENTID = sqlite_datareadert.GetInt32(0);
                    int COMPID = sqlite_datareadert.GetInt32(2);
                    int ACTIVITYID = sqlite_datareadert.GetInt32(3);
                    int RANKID = sqlite_datareadert.GetInt32(4);
                    int EVENTTYPEID = sqlite_datareadert.GetInt32(5);
                    string DATE = sqlite_datareadert.GetString(1);

                    lboxEvents.Items.Add(string.Format(output, EVENTID, COMPID, ACTIVITYID, EVENTTYPEID, RANKID, DATE));
                }
                sqlite_datareadert.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnsearchevents_Click(object sender, EventArgs e)
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
                lboxEvents.Items.Clear();
                // OR comp_id = @txtCompID OR activity_id = @txtActivityID OR event_type_id = @eventtypeid OR rank_id = @txtRank OR event_date = @txtDate
                SQLiteDataReader sqlite_datareader;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblEvents WHERE comp_id = @compid OR activity_id = @tactivityid OR event_type_id = @Participating OR rank_id = @rank OR event_date = @date";


                SQOptimial(sender, new EventArgs());

                sqlite_datareader = sqlite_cmd.ExecuteReader();
                lboxEvents.Items.Add(string.Format(output, "Event ID", "Comp ID", "Activity ID", "Event Type ID", "Rank", "Event Date"));

                while (sqlite_datareader.Read())
                {
                    int EVENTID = sqlite_datareader.GetInt32(0);
                    int COMPID = sqlite_datareader.GetInt32(1);
                    int ACTIVITYID = sqlite_datareader.GetInt32(2);
                    int EVENTTYPEID = sqlite_datareader.GetInt32(3);
                    int RANKID = sqlite_datareader.GetInt32(4);
                    string DATE = sqlite_datareader.GetString(5);
                    lboxEvents.Items.Add(string.Format(output, EVENTID, COMPID, ACTIVITYID, EVENTTYPEID, RANKID, DATE));
                    txtEvent.Clear();
                    txtCompID.Clear();
                    txteventtypeid.Clear();
                    txtActivityID.Clear();
                    txtDate.Clear();
                    txtRank.Clear();
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnnewEvents_Click(object sender, EventArgs e)
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
                sqlite_cmd.CommandText = "SELECT * FROM TblEvents WHERE event_id = @eventuid;";
                sqlite_cmd.Parameters.AddWithValue("@eventuid", txtEvent.Text);
                sqlite_datareaderz = sqlite_cmd.ExecuteReader();
                while (sqlite_datareaderz.Read())
                {
                    int ITEMIDCODECOMPARISON = sqlite_datareaderz.GetInt32(0);
                    int cuscompare = sqlite_datareaderz.GetInt32(1);
                    int txtEVentIDint = Convert.ToInt32(txtEvent.Text);
                    int txtCompIDs = Convert.ToInt32(txtCompID.Text);

                    if (ITEMIDCODECOMPARISON == txtEVentIDint && cuscompare == txtCompIDs)
                    {
                        MessageBox.Show("Event and Competitor with the ID codes " + ITEMIDCODECOMPARISON + " and " + cuscompare + " already Exists. Please enter a different ID or edit the existing item");
                        txtEvent.Clear();
                        txtActivityID.Clear();
                        txtCompID.Clear();
                        txteventtypeid.Clear();
                        txtRank.Clear();
                        txtDate.Clear();
                    }
                }
                sqlite_datareaderz.Close();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO TblEvents(event_id,comp_id,activity_id,event_type_id,rank_id,event_date) VALUES(@eventid,@tactivityid,@Participating,@compid,@rank,@date); ";

                SQOptimial(sender, new EventArgs());



                if (txtEvent.Text == "" || txtActivityID.Text == "" || txtCompID.Text == "" || txteventtypeid.Text == "" || txtRank.Text == "" || txtDate.Text == "")
                {
                    MessageBox.Show("A field has been left empty. All fields must be filled before adding a record");
                }
                else
                {
                    SQLiteDataReader sqlite_datareader;
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    MessageBox.Show("New Event Added!");
                    txtEvent.Clear();
                    txtActivityID.Clear();
                    txtCompID.Clear();
                    txtRank.Clear();
                    txteventtypeid.Clear();
                    txtDate.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnupdateEvents_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            SQLiteDataReader sqlite_datareader;
            sqlite_conn.Open();

            if (txtCompID.Text == "")
            {
                MessageBox.Show("No entered Comp ID to update");
                txtEvent.Clear();
                txtActivityID.Clear();
                txtCompID.Clear();
                txtRank.Clear();
                txteventtypeid.Clear();
                txtDate.Clear();
            }
            else
            {
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "Update TblEvents SET event_id = @eventid, comp_id = @compid, activity_id = @tactivityid, event_type_id= @Participating,rank_id = @rank, event_date = @date WHERE comp_id =@compid";

                SQOptimial(sender, new EventArgs());

                if (txtEvent.Text == "" || txtActivityID.Text == "" || txteventtypeid.Text == "" || txtRank.Text == "" || txtDate.Text == "")
                {
                    MessageBox.Show("A field has been left empty. All fields must be filled before updating a record");
                }
                else
                {

                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    sqlite_datareader.Close();
                    MessageBox.Show("Record Updated");
                    txtEvent.Clear();
                    txtActivityID.Clear();
                    txtCompID.Clear();
                    txtRank.Clear();
                    txteventtypeid.Clear();
                    txtDate.Clear();

                }
            }

        }

        private void btndeleteEvents_Click(object sender, EventArgs e)
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
                sqlite_cmd.CommandText = "DELETE FROM TblEvents WHERE comp_id = @COMPID";
                sqlite_cmd.Parameters.AddWithValue("@COMPID", txtCompID.Text);
                sqlite_datareaderz = sqlite_cmd.ExecuteReader();
                MessageBox.Show("Event Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void EventsTimetable_Load(object sender, EventArgs e)
        {

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
    }
}
