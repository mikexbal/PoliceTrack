namespace PoliceDatabaseProgam
{
    partial class MainArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainArea));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnWipe = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPoliceDatabase = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(20, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 52);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "File Report";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnWipe
            // 
            this.btnWipe.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWipe.Location = new System.Drawing.Point(20, 94);
            this.btnWipe.Margin = new System.Windows.Forms.Padding(2);
            this.btnWipe.Name = "btnWipe";
            this.btnWipe.Size = new System.Drawing.Size(95, 53);
            this.btnWipe.TabIndex = 8;
            this.btnWipe.Text = "Wipe";
            this.btnWipe.UseVisualStyleBackColor = true;
            this.btnWipe.Click += new System.EventHandler(this.btnWipe_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(134, 18);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(88, 52);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View Records";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(134, 94);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "View Officers";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblPoliceDatabase
            // 
            this.lblPoliceDatabase.AutoSize = true;
            this.lblPoliceDatabase.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliceDatabase.Location = new System.Drawing.Point(63, 23);
            this.lblPoliceDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoliceDatabase.Name = "lblPoliceDatabase";
            this.lblPoliceDatabase.Size = new System.Drawing.Size(272, 26);
            this.lblPoliceDatabase.TabIndex = 11;
            this.lblPoliceDatabase.Text = "MBNR Crime Bureau";
            this.lblPoliceDatabase.Click += new System.EventHandler(this.lblPoliceDatabase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnWipe);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Location = new System.Drawing.Point(68, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 152);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // MainArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPoliceDatabase);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainArea";
            this.Text = "MBNR Crime Bureau";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWipe;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPoliceDatabase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}