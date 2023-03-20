
namespace BTEC_Project
{
    partial class Leaderboards
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBoxLeaderboards = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDisplaySingleLeaderBoard = new System.Windows.Forms.Button();
            this.btnMultipleLeaderboard = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSingleInv = new System.Windows.Forms.Button();
            this.btnMultiIndv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBoxLeaderboards
            // 
            this.lBoxLeaderboards.BackColor = System.Drawing.Color.Black;
            this.lBoxLeaderboards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxLeaderboards.ForeColor = System.Drawing.Color.Red;
            this.lBoxLeaderboards.FormattingEnabled = true;
            this.lBoxLeaderboards.ItemHeight = 25;
            this.lBoxLeaderboards.Location = new System.Drawing.Point(382, 85);
            this.lBoxLeaderboards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lBoxLeaderboards.Name = "lBoxLeaderboards";
            this.lBoxLeaderboards.Size = new System.Drawing.Size(1024, 652);
            this.lBoxLeaderboards.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(30, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 42);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Leaderboards";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDisplaySingleLeaderBoard
            // 
            this.btnDisplaySingleLeaderBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplaySingleLeaderBoard.Location = new System.Drawing.Point(30, 85);
            this.btnDisplaySingleLeaderBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplaySingleLeaderBoard.Name = "btnDisplaySingleLeaderBoard";
            this.btnDisplaySingleLeaderBoard.Size = new System.Drawing.Size(334, 88);
            this.btnDisplaySingleLeaderBoard.TabIndex = 19;
            this.btnDisplaySingleLeaderBoard.Text = "Display Single Teams Leaderboards";
            this.btnDisplaySingleLeaderBoard.UseVisualStyleBackColor = true;
            this.btnDisplaySingleLeaderBoard.Click += new System.EventHandler(this.btnDisplaySingleLeaderBoard_Click);
            // 
            // btnMultipleLeaderboard
            // 
            this.btnMultipleLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleLeaderboard.Location = new System.Drawing.Point(30, 199);
            this.btnMultipleLeaderboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultipleLeaderboard.Name = "btnMultipleLeaderboard";
            this.btnMultipleLeaderboard.Size = new System.Drawing.Size(334, 88);
            this.btnMultipleLeaderboard.TabIndex = 20;
            this.btnMultipleLeaderboard.Text = "Display Multiple Teams Leaderboards";
            this.btnMultipleLeaderboard.UseVisualStyleBackColor = true;
            this.btnMultipleLeaderboard.Click += new System.EventHandler(this.btnMultipleLeaderboard_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(30, 541);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(334, 88);
            this.btnMainMenu.TabIndex = 21;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(30, 648);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(334, 88);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSingleInv
            // 
            this.btnSingleInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleInv.Location = new System.Drawing.Point(30, 313);
            this.btnSingleInv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSingleInv.Name = "btnSingleInv";
            this.btnSingleInv.Size = new System.Drawing.Size(334, 88);
            this.btnSingleInv.TabIndex = 23;
            this.btnSingleInv.Text = "Display Single Individual Leaderboards";
            this.btnSingleInv.UseVisualStyleBackColor = true;
            this.btnSingleInv.Click += new System.EventHandler(this.btnSingleInv_Click);
            // 
            // btnMultiIndv
            // 
            this.btnMultiIndv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiIndv.Location = new System.Drawing.Point(30, 427);
            this.btnMultiIndv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiIndv.Name = "btnMultiIndv";
            this.btnMultiIndv.Size = new System.Drawing.Size(334, 88);
            this.btnMultiIndv.TabIndex = 24;
            this.btnMultiIndv.Text = "Display Multiple Individual Leaderboards";
            this.btnMultiIndv.UseVisualStyleBackColor = true;
            this.btnMultiIndv.Click += new System.EventHandler(this.btnMultiIndv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(763, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "After Actions have been completed, click the Display button to refresh the listbo" +
    "x";
            // 
            // Leaderboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1419, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMultiIndv);
            this.Controls.Add(this.btnSingleInv);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnMultipleLeaderboard);
            this.Controls.Add(this.btnDisplaySingleLeaderBoard);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lBoxLeaderboards);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Leaderboards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboards";
            this.Load += new System.EventHandler(this.Leaderboards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxLeaderboards;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDisplaySingleLeaderBoard;
        private System.Windows.Forms.Button btnMultipleLeaderboard;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSingleInv;
        private System.Windows.Forms.Button btnMultiIndv;
        private System.Windows.Forms.Label label1;
    }
}