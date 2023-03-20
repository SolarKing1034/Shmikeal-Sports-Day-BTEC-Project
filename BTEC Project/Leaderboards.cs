using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection;

namespace BTEC_Project
{
    public partial class Leaderboards : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public Leaderboards()
        {
            InitializeComponent();
        }
        string str = "Individual";
        string output = "{0,-20}\t{1,-20}\t{2,-20}";
        string outputto = "{0,-10}\t{1,-20}\t{2,-20}\t{3,-20}\t{4,-20}\t{5,-30}";


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnMultiIndv_Click(object sender, EventArgs e)
        {
            lBoxLeaderboards.Items.Clear();
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareader;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT TblCompetitor.comp_id, TblCompetitor.forename, TblCompetitor.surname, " +
                  "TblCompetitor.team_type, TblCompetitor.events_participating_in," +
                  "SUM(TblPointsAwarded.points_worth) " +
                  "As total_points " +
                  "FROM TblCompetitor " +
                  "INNER JOIN TblEvents on TblCompetitor.comp_id = TblEvents.comp_id " +
                  "INNER JOIN TblActivities on TblEvents.activity_id = TblActivities.activity_id " +
                  "INNER JOIN TblPointsAwarded on TblEvents.rank_id = TblPointsAwarded.rank " +
                  "WHERE TblCompetitor.team_type ='Individual' AND TblCompetitor.events_participating_in='Multiple' " +
                  "GROUP BY TblCompetitor.comp_id " +
                  "ORDER BY rank DESC";

                sqlite_datareader = sqlite_cmd.ExecuteReader();
                lBoxLeaderboards.Items.Add(string.Format(outputto, "Rank", "Forename", "Surname", "Team", "Events In", "Comp ID"));

                while (sqlite_datareader.Read())
                {
                    int ID = sqlite_datareader.GetInt32(0);
                    string forename = sqlite_datareader.GetString(1);
                    string surname = sqlite_datareader.GetString(2);
                    string eventspartin = sqlite_datareader.GetString(3);
                    string comptype = sqlite_datareader.GetString(4);
                    int rank = sqlite_datareader.GetInt32(5);
                    lBoxLeaderboards.Items.Add(string.Format(outputto, rank, forename, surname, eventspartin, comptype, ID));
                }
                sqlite_conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnSingleInv_Click(object sender, EventArgs e)
        {
            string str = "Individual";
            lBoxLeaderboards.Items.Clear();
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareader;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT TblCompetitor.comp_id, TblCompetitor.forename, TblCompetitor.surname, " +
                  "TblCompetitor.team_type, TblCompetitor.events_participating_in, " +
                  "SUM(TblPointsAwarded.points_worth) As total_points FROM TblCompetitor " +
                  "INNER JOIN TblEvents on TblCompetitor.comp_id = TblEvents.comp_id " +
                  "INNER JOIN TblActivities on TblEvents.activity_id = TblActivities.activity_id " +
                  "INNER JOIN TblPointsAwarded on TblEvents.rank_id = TblPointsAwarded.rank " +
                  "WHERE TblCompetitor.team_type ='Individual' AND TblCompetitor.events_participating_in='Single' " +
                  "GROUP BY TblCompetitor.comp_id " +
                  "ORDER BY rank DESC ";


                sqlite_datareader = sqlite_cmd.ExecuteReader();
                lBoxLeaderboards.Items.Add(string.Format(outputto, "Rank", "Forename", "Surname", "Team", "Events In", "Comp ID"));

                while (sqlite_datareader.Read())
                {
                    int ID = sqlite_datareader.GetInt32(0);
                    string forename = sqlite_datareader.GetString(1);
                    string surname = sqlite_datareader.GetString(2);
                    string eventspartin = sqlite_datareader.GetString(3);
                    string comptype = sqlite_datareader.GetString(4);
                    int rank = sqlite_datareader.GetInt32(5);
                    lBoxLeaderboards.Items.Add(string.Format(outputto, rank, forename, surname, eventspartin, comptype, ID));
                }
                sqlite_conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDisplaySingleLeaderBoard_Click(object sender, EventArgs e)
        {
            lBoxLeaderboards.Items.Clear();
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            try
            {
                string inv = "Individual";
                SQLiteDataReader sqlite_datareader;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT TblCompetitor.team_type,TblCompetitor.events_participating_in, SUM(TblPointsAwarded.points_worth) " +
                "AS total_points FROM TblCompetitor " +
                "INNER JOIN TblEvents on TblCompetitor.comp_id = TblEvents.comp_id " +
                "INNER JOIN TblActivities on TblEvents.activity_id = TblActivities.activity_id " +
                "INNER JOIN TblPointsAwarded on TblEvents.rank_id = TblPointsAwarded.rank " +
                "INNER JOIN TblEventTypes on TblEvents.event_type_id = TblEventTypes.event_type_id " +
                "WHERE TblCompetitor.team_type != 'Individual' AND TblCompetitor.events_participating_in='Single' " +
                "GROUP BY TblCompetitor.team_type ORDER BY total_points DESC";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                lBoxLeaderboards.Items.Add(string.Format(output, "Team Name", "Team Type", "Total Points"));
                while (sqlite_datareader.Read()) 
                {
                    string teamname = sqlite_datareader.GetString(0);
                    string comptype = sqlite_datareader.GetString(1);
                    int points = sqlite_datareader.GetInt32(2);
                    lBoxLeaderboards.Items.Add(string.Format(output, teamname,comptype,points));
                }
                sqlite_conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMultipleLeaderboard_Click(object sender, EventArgs e)
        {
            lBoxLeaderboards.Items.Clear();
            sqlite_conn = new SQLiteConnection("Data Source=ProjectDB.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareader;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT TblCompetitor.team_type,TblCompetitor.events_participating_in, SUM(TblPointsAwarded.points_worth) " +
                "AS total_points FROM TblCompetitor " +
                "INNER JOIN TblEvents on TblCompetitor.comp_id = TblEvents.comp_id " +
                "INNER JOIN TblActivities on TblEvents.activity_id = TblActivities.activity_id " +
                "INNER JOIN TblPointsAwarded on TblEvents.rank_id = TblPointsAwarded.rank " +
                "INNER JOIN TblEventTypes on TblEvents.event_type_id = TblEventTypes.event_type_id " +
                "WHERE TblCompetitor.team_type != 'Individual' AND TblCompetitor.events_participating_in='Multiple' " +
                "GROUP BY TblCompetitor.team_type ORDER BY total_points DESC";

                sqlite_datareader = sqlite_cmd.ExecuteReader();

                lBoxLeaderboards.Items.Add(string.Format(output, "Team Name", "Team Type", "Total Points"));
                while (sqlite_datareader.Read())
                {
                    string teamname = sqlite_datareader.GetString(0);
                    string comptype = sqlite_datareader.GetString(1);
                    int points = sqlite_datareader.GetInt32(2);
                    lBoxLeaderboards.Items.Add(string.Format(output, teamname, comptype, points));
                }
                sqlite_conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new MainMenu();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Leaderboards_Load(object sender, EventArgs e)
        {

        }
    }
}
