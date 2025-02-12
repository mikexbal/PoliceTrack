namespace PoliceDatabaseProgam
{
    partial class frmLogin
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
            this.lblPoliceDatabase = new System.Windows.Forms.Label();
            this.lblBadgeID = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbBadgeID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoliceDatabase
            // 
            this.lblPoliceDatabase.AutoSize = true;
            this.lblPoliceDatabase.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliceDatabase.Location = new System.Drawing.Point(45, 54);
            this.lblPoliceDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoliceDatabase.Name = "lblPoliceDatabase";
            this.lblPoliceDatabase.Size = new System.Drawing.Size(272, 26);
            this.lblPoliceDatabase.TabIndex = 0;
            this.lblPoliceDatabase.Text = "MBNR Crime Bureau";
            // 
            // lblBadgeID
            // 
            this.lblBadgeID.AutoSize = true;
            this.lblBadgeID.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadgeID.Location = new System.Drawing.Point(90, 147);
            this.lblBadgeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBadgeID.Name = "lblBadgeID";
            this.lblBadgeID.Size = new System.Drawing.Size(62, 12);
            this.lblBadgeID.TabIndex = 1;
            this.lblBadgeID.Text = "Badge ID:";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(117, 107);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(136, 12);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "Incorrect Password!";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(90, 170);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 12);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // tbBadgeID
            // 
            this.tbBadgeID.Location = new System.Drawing.Point(165, 143);
            this.tbBadgeID.Margin = new System.Windows.Forms.Padding(2);
            this.tbBadgeID.Name = "tbBadgeID";
            this.tbBadgeID.Size = new System.Drawing.Size(92, 20);
            this.tbBadgeID.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(165, 166);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(92, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(92, 205);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(181, 205);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(72, 36);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 256);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbBadgeID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblBadgeID);
            this.Controls.Add(this.lblPoliceDatabase);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoliceDatabase;
        private System.Windows.Forms.Label lblBadgeID;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbBadgeID;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreate;
    }
}

