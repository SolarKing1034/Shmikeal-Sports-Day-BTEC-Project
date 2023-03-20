
namespace BTEC_Project
{
    partial class AdminArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminArea));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDBBackup = new System.Windows.Forms.Button();
            this.btnDBDelete = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnExisSys = new System.Windows.Forms.Button();
            this.AdminPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(17, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(160, 42);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Admin Area";
            // 
            // btnDBBackup
            // 
            this.btnDBBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBBackup.Location = new System.Drawing.Point(351, 115);
            this.btnDBBackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDBBackup.Name = "btnDBBackup";
            this.btnDBBackup.Size = new System.Drawing.Size(301, 72);
            this.btnDBBackup.TabIndex = 10;
            this.btnDBBackup.Text = "Backup Database";
            this.btnDBBackup.UseVisualStyleBackColor = true;
            this.btnDBBackup.Click += new System.EventHandler(this.btnDBBackup_Click);
            // 
            // btnDBDelete
            // 
            this.btnDBDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBDelete.Location = new System.Drawing.Point(351, 195);
            this.btnDBDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDBDelete.Name = "btnDBDelete";
            this.btnDBDelete.Size = new System.Drawing.Size(301, 72);
            this.btnDBDelete.TabIndex = 11;
            this.btnDBDelete.Text = "Delete Database";
            this.btnDBDelete.UseVisualStyleBackColor = true;
            this.btnDBDelete.Click += new System.EventHandler(this.btnDBDelete_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(351, 277);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(301, 72);
            this.btnMainMenu.TabIndex = 12;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnExisSys
            // 
            this.btnExisSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExisSys.Location = new System.Drawing.Point(351, 358);
            this.btnExisSys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExisSys.Name = "btnExisSys";
            this.btnExisSys.Size = new System.Drawing.Size(301, 72);
            this.btnExisSys.TabIndex = 13;
            this.btnExisSys.Text = "Exit System";
            this.btnExisSys.UseVisualStyleBackColor = true;
            this.btnExisSys.Click += new System.EventHandler(this.btnExisSys_Click);
            // 
            // AdminPicBox
            // 
            this.AdminPicBox.Image = ((System.Drawing.Image)(resources.GetObject("AdminPicBox.Image")));
            this.AdminPicBox.Location = new System.Drawing.Point(17, 115);
            this.AdminPicBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminPicBox.Name = "AdminPicBox";
            this.AdminPicBox.Size = new System.Drawing.Size(326, 315);
            this.AdminPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminPicBox.TabIndex = 14;
            this.AdminPicBox.TabStop = false;
            // 
            // AdminArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(670, 462);
            this.Controls.Add(this.AdminPicBox);
            this.Controls.Add(this.btnExisSys);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnDBDelete);
            this.Controls.Add(this.btnDBBackup);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminArea";
            this.Load += new System.EventHandler(this.AdminArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDBBackup;
        private System.Windows.Forms.Button btnDBDelete;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnExisSys;
        private System.Windows.Forms.PictureBox AdminPicBox;
    }
}