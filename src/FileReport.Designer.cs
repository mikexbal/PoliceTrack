namespace PoliceDatabaseProgam
{
    partial class FileReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileReport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCatergory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.chkIsSolved = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblImgUrl = new System.Windows.Forms.Label();
            this.txtImgUrl = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtCHeight = new System.Windows.Forms.TextBox();
            this.lblRentCostPerDay = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPoliceDatabase = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(370, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCatergory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Controls.Add(this.numYear);
            this.groupBox2.Controls.Add(this.chkIsSolved);
            this.groupBox2.Controls.Add(this.cmbCategory);
            this.groupBox2.Controls.Add(this.lblLocation);
            this.groupBox2.Controls.Add(this.txtLocation);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Location = new System.Drawing.Point(263, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 247);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Report";
            // 
            // lblCatergory
            // 
            this.lblCatergory.AutoSize = true;
            this.lblCatergory.Location = new System.Drawing.Point(20, 27);
            this.lblCatergory.Name = "lblCatergory";
            this.lblCatergory.Size = new System.Drawing.Size(93, 12);
            this.lblCatergory.TabIndex = 5;
            this.lblCatergory.Text = "Alleged Crime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "Has this Case been Solved";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(177, 27);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(88, 12);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year of Crime";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(159, 42);
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(120, 20);
            this.numYear.TabIndex = 6;
            this.numYear.ValueChanged += new System.EventHandler(this.numYear_ValueChanged);
            // 
            // chkIsSolved
            // 
            this.chkIsSolved.AutoSize = true;
            this.chkIsSolved.Location = new System.Drawing.Point(96, 223);
            this.chkIsSolved.Name = "chkIsSolved";
            this.chkIsSolved.Size = new System.Drawing.Size(68, 16);
            this.chkIsSolved.TabIndex = 12;
            this.chkIsSolved.Text = "Solved";
            this.chkIsSolved.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(8, 42);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 20);
            this.cmbCategory.TabIndex = 4;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(116, 90);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(60, 12);
            this.lblLocation.TabIndex = 16;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(86, 103);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(121, 20);
            this.txtLocation.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(116, 145);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 12);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 166);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(290, 20);
            this.txtDescription.TabIndex = 13;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(3, 184);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(124, 20);
            this.txtWeight.TabIndex = 0;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 168);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(48, 12);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(4, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Suspect Name";
            // 
            // lblImgUrl
            // 
            this.lblImgUrl.AutoSize = true;
            this.lblImgUrl.Location = new System.Drawing.Point(6, 27);
            this.lblImgUrl.Name = "lblImgUrl";
            this.lblImgUrl.Size = new System.Drawing.Size(85, 12);
            this.lblImgUrl.TabIndex = 18;
            this.lblImgUrl.Text = "Mugshot URL";
            // 
            // txtImgUrl
            // 
            this.txtImgUrl.Location = new System.Drawing.Point(8, 42);
            this.txtImgUrl.Name = "txtImgUrl";
            this.txtImgUrl.Size = new System.Drawing.Size(150, 20);
            this.txtImgUrl.TabIndex = 17;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(4, 126);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(141, 20);
            this.numAge.TabIndex = 8;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(6, 111);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 12);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // txtCHeight
            // 
            this.txtCHeight.Location = new System.Drawing.Point(4, 233);
            this.txtCHeight.Name = "txtCHeight";
            this.txtCHeight.Size = new System.Drawing.Size(123, 20);
            this.txtCHeight.TabIndex = 10;
            // 
            // lblRentCostPerDay
            // 
            this.lblRentCostPerDay.AutoSize = true;
            this.lblRentCostPerDay.Location = new System.Drawing.Point(6, 218);
            this.lblRentCostPerDay.Name = "lblRentCostPerDay";
            this.lblRentCostPerDay.Size = new System.Drawing.Size(45, 12);
            this.lblRentCostPerDay.TabIndex = 11;
            this.lblRentCostPerDay.Text = "Height";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(324, 379);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 36);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "File Report";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPoliceDatabase
            // 
            this.lblPoliceDatabase.AutoSize = true;
            this.lblPoliceDatabase.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliceDatabase.Location = new System.Drawing.Point(33, 71);
            this.lblPoliceDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoliceDatabase.Name = "lblPoliceDatabase";
            this.lblPoliceDatabase.Size = new System.Drawing.Size(272, 26);
            this.lblPoliceDatabase.TabIndex = 30;
            this.lblPoliceDatabase.Text = "MBNR Crime Bureau";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblImgUrl);
            this.groupBox1.Controls.Add(this.txtImgUrl);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.lblRentCostPerDay);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.txtCHeight);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.numAge);
            this.groupBox1.Location = new System.Drawing.Point(30, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 268);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criminal Info";
            // 
            // FileReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(586, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPoliceDatabase);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FileReport";
            this.Text = "File Report";
            this.Load += new System.EventHandler(this.FileReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCatergory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkIsSolved;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblImgUrl;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtImgUrl;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCHeight;
        private System.Windows.Forms.Label lblRentCostPerDay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPoliceDatabase;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}