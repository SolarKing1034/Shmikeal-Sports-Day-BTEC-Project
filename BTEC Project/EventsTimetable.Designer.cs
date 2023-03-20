
namespace BTEC_Project
{
    partial class EventsTimetable
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.lboxEvents = new System.Windows.Forms.ListBox();
            this.btndeleteEvents = new System.Windows.Forms.Button();
            this.txtActivityID = new System.Windows.Forms.TextBox();
            this.btndisplayevents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsearchevents = new System.Windows.Forms.Button();
            this.btnupdateEvents = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.txtCompID = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.btnnewEvents = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txteventtypeid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(17, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(249, 42);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Events Timetable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 510);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 42;
            this.label2.Text = "Activity ID";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(17, 715);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(596, 40);
            this.button7.TabIndex = 53;
            this.button7.Text = "Exit System";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lboxEvents
            // 
            this.lboxEvents.BackColor = System.Drawing.Color.Black;
            this.lboxEvents.ForeColor = System.Drawing.Color.Red;
            this.lboxEvents.FormattingEnabled = true;
            this.lboxEvents.ItemHeight = 25;
            this.lboxEvents.Location = new System.Drawing.Point(623, 123);
            this.lboxEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lboxEvents.Name = "lboxEvents";
            this.lboxEvents.Size = new System.Drawing.Size(970, 629);
            this.lboxEvents.TabIndex = 46;
            // 
            // btndeleteEvents
            // 
            this.btndeleteEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteEvents.Location = new System.Drawing.Point(209, 295);
            this.btndeleteEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndeleteEvents.Name = "btndeleteEvents";
            this.btndeleteEvents.Size = new System.Drawing.Size(180, 82);
            this.btndeleteEvents.TabIndex = 51;
            this.btndeleteEvents.Text = "Delete Events with Inputted Comp ID";
            this.btndeleteEvents.UseVisualStyleBackColor = true;
            this.btndeleteEvents.Click += new System.EventHandler(this.btndeleteEvents_Click);
            // 
            // txtActivityID
            // 
            this.txtActivityID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtActivityID.ForeColor = System.Drawing.Color.Red;
            this.txtActivityID.Location = new System.Drawing.Point(273, 510);
            this.txtActivityID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActivityID.Name = "txtActivityID";
            this.txtActivityID.Size = new System.Drawing.Size(301, 31);
            this.txtActivityID.TabIndex = 40;
            // 
            // btndisplayevents
            // 
            this.btndisplayevents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisplayevents.Location = new System.Drawing.Point(6, 128);
            this.btndisplayevents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndisplayevents.Name = "btndisplayevents";
            this.btndisplayevents.Size = new System.Drawing.Size(180, 82);
            this.btndisplayevents.TabIndex = 47;
            this.btndisplayevents.Text = "Display All Events";
            this.btndisplayevents.UseVisualStyleBackColor = true;
            this.btndisplayevents.Click += new System.EventHandler(this.btndisplayevents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Event ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 520);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 43;
            this.label3.Visible = false;
            // 
            // btnsearchevents
            // 
            this.btnsearchevents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearchevents.Location = new System.Drawing.Point(209, 128);
            this.btnsearchevents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsearchevents.Name = "btnsearchevents";
            this.btnsearchevents.Size = new System.Drawing.Size(180, 82);
            this.btnsearchevents.TabIndex = 48;
            this.btnsearchevents.Text = "Search Events with Comp ID, Activity ID, Event Type ID or Rank";
            this.btnsearchevents.UseVisualStyleBackColor = true;
            this.btnsearchevents.Click += new System.EventHandler(this.btnsearchevents_Click);
            // 
            // btnupdateEvents
            // 
            this.btnupdateEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateEvents.Location = new System.Drawing.Point(6, 295);
            this.btnupdateEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdateEvents.Name = "btnupdateEvents";
            this.btnupdateEvents.Size = new System.Drawing.Size(180, 82);
            this.btnupdateEvents.TabIndex = 50;
            this.btnupdateEvents.Text = "Update Events with Inputted Comp ID";
            this.btnupdateEvents.UseVisualStyleBackColor = true;
            this.btnupdateEvents.Click += new System.EventHandler(this.btnupdateEvents_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(421, 295);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(180, 82);
            this.btnMainMenu.TabIndex = 52;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // txtCompID
            // 
            this.txtCompID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCompID.ForeColor = System.Drawing.Color.Red;
            this.txtCompID.Location = new System.Drawing.Point(273, 458);
            this.txtCompID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompID.Name = "txtCompID";
            this.txtCompID.Size = new System.Drawing.Size(301, 31);
            this.txtCompID.TabIndex = 39;
            // 
            // txtEvent
            // 
            this.txtEvent.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEvent.ForeColor = System.Drawing.Color.Red;
            this.txtEvent.Location = new System.Drawing.Point(273, 402);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(301, 31);
            this.txtEvent.TabIndex = 37;
            // 
            // btnnewEvents
            // 
            this.btnnewEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewEvents.Location = new System.Drawing.Point(421, 128);
            this.btnnewEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnewEvents.Name = "btnnewEvents";
            this.btnnewEvents.Size = new System.Drawing.Size(180, 82);
            this.btnnewEvents.TabIndex = 49;
            this.btnnewEvents.Text = "Add New Events";
            this.btnnewEvents.UseVisualStyleBackColor = true;
            this.btnnewEvents.Click += new System.EventHandler(this.btnnewEvents_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 31);
            this.label4.TabIndex = 44;
            this.label4.Text = "Competitior\'s ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 665);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 31);
            this.label6.TabIndex = 54;
            this.label6.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDate.ForeColor = System.Drawing.Color.Red;
            this.txtDate.Location = new System.Drawing.Point(273, 667);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(301, 31);
            this.txtDate.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 612);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 31);
            this.label5.TabIndex = 45;
            this.label5.Text = "Rank";
            // 
            // txtRank
            // 
            this.txtRank.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRank.ForeColor = System.Drawing.Color.Red;
            this.txtRank.Location = new System.Drawing.Point(273, 607);
            this.txtRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(301, 31);
            this.txtRank.TabIndex = 38;
            // 
            // txteventtypeid
            // 
            this.txteventtypeid.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txteventtypeid.ForeColor = System.Drawing.Color.Red;
            this.txteventtypeid.Location = new System.Drawing.Point(273, 562);
            this.txteventtypeid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txteventtypeid.Name = "txteventtypeid";
            this.txteventtypeid.Size = new System.Drawing.Size(301, 31);
            this.txteventtypeid.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 567);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 31);
            this.label7.TabIndex = 57;
            this.label7.Text = "Event Type ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(955, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(653, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "After Actions have been completed, click the Display button to refresh the listbo" +
    "x";
            // 
            // EventsTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1620, 768);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txteventtypeid);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btndeleteEvents);
            this.Controls.Add(this.btnupdateEvents);
            this.Controls.Add(this.btnnewEvents);
            this.Controls.Add(this.btnsearchevents);
            this.Controls.Add(this.btndisplayevents);
            this.Controls.Add(this.lboxEvents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActivityID);
            this.Controls.Add(this.txtCompID);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EventsTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventsTimetable";
            this.Load += new System.EventHandler(this.EventsTimetable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox lboxEvents;
        private System.Windows.Forms.Button btndeleteEvents;
        private System.Windows.Forms.TextBox txtActivityID;
        private System.Windows.Forms.Button btndisplayevents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsearchevents;
        private System.Windows.Forms.Button btnupdateEvents;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TextBox txtCompID;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Button btnnewEvents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txteventtypeid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}