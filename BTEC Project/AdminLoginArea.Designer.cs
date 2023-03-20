
namespace BTEC_Project
{
    partial class AdminLoginArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginArea));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExitSys = new System.Windows.Forms.Button();
            this.btnValidatePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowOrHide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowOrHide)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Black;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.ForeColor = System.Drawing.Color.Red;
            this.btnMainMenu.Location = new System.Drawing.Point(324, 83);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(237, 48);
            this.btnMainMenu.TabIndex = 23;
            this.btnMainMenu.Text = "--> Go Back";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(50, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "//Password =  password1";
            // 
            // btnExitSys
            // 
            this.btnExitSys.BackColor = System.Drawing.Color.Black;
            this.btnExitSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitSys.ForeColor = System.Drawing.Color.Red;
            this.btnExitSys.Location = new System.Drawing.Point(324, 150);
            this.btnExitSys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitSys.Name = "btnExitSys";
            this.btnExitSys.Size = new System.Drawing.Size(237, 47);
            this.btnExitSys.TabIndex = 21;
            this.btnExitSys.Text = "--> Exit System";
            this.btnExitSys.UseVisualStyleBackColor = false;
            this.btnExitSys.Click += new System.EventHandler(this.btnExitSys_Click);
            // 
            // btnValidatePass
            // 
            this.btnValidatePass.BackColor = System.Drawing.Color.Black;
            this.btnValidatePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidatePass.ForeColor = System.Drawing.Color.Red;
            this.btnValidatePass.Location = new System.Drawing.Point(323, 20);
            this.btnValidatePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidatePass.Name = "btnValidatePass";
            this.btnValidatePass.Size = new System.Drawing.Size(237, 47);
            this.btnValidatePass.TabIndex = 20;
            this.btnValidatePass.Text = "--> Continue";
            this.btnValidatePass.UseVisualStyleBackColor = false;
            this.btnValidatePass.Click += new System.EventHandler(this.btnValidatePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Password: ";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(124, 103);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(138, 31);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Text = " ";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(26, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(170, 42);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Admin Login";
            // 
            // ShowOrHide
            // 
            this.ShowOrHide.Image = ((System.Drawing.Image)(resources.GetObject("ShowOrHide.Image")));
            this.ShowOrHide.Location = new System.Drawing.Point(271, 103);
            this.ShowOrHide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowOrHide.Name = "ShowOrHide";
            this.ShowOrHide.Size = new System.Drawing.Size(44, 38);
            this.ShowOrHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowOrHide.TabIndex = 24;
            this.ShowOrHide.TabStop = false;
            this.ShowOrHide.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminLoginArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(577, 217);
            this.Controls.Add(this.ShowOrHide);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitSys);
            this.Controls.Add(this.btnValidatePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminLoginArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginArea";
            this.Load += new System.EventHandler(this.AdminLoginArea_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ShowOrHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExitSys;
        private System.Windows.Forms.Button btnValidatePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox ShowOrHide;
    }
}