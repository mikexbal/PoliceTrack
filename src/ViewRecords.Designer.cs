namespace PoliceDatabaseProgam
{
    partial class ViewRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecords));
            this.btnUpdateCriminal = new System.Windows.Forms.Button();
            this.dataGridViewCriminals = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBoxCarImage = new System.Windows.Forms.PictureBox();
            this.groupCarDetails = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblSolved = new System.Windows.Forms.Label();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSuspect = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPoliceDatabase = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriminals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage)).BeginInit();
            this.groupCarDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateCriminal
            // 
            this.btnUpdateCriminal.Location = new System.Drawing.Point(384, 455);
            this.btnUpdateCriminal.Name = "btnUpdateCriminal";
            this.btnUpdateCriminal.Size = new System.Drawing.Size(151, 34);
            this.btnUpdateCriminal.TabIndex = 31;
            this.btnUpdateCriminal.Text = "Update Case Info";
            this.btnUpdateCriminal.UseVisualStyleBackColor = true;
            this.btnUpdateCriminal.Click += new System.EventHandler(this.btnUpdateCriminal_Click);
            // 
            // dataGridViewCriminals
            // 
            this.dataGridViewCriminals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCriminals.Location = new System.Drawing.Point(274, 196);
            this.dataGridViewCriminals.Name = "dataGridViewCriminals";
            this.dataGridViewCriminals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCriminals.Size = new System.Drawing.Size(489, 215);
            this.dataGridViewCriminals.TabIndex = 30;
            this.dataGridViewCriminals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCriminals_CellContentClick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "Search For A Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "Criminal Records";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(384, 429);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 20);
            this.txtSearch.TabIndex = 26;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(541, 455);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 34);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search Cases";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // pictureBoxCarImage
            // 
            this.pictureBoxCarImage.Location = new System.Drawing.Point(11, 41);
            this.pictureBoxCarImage.Name = "pictureBoxCarImage";
            this.pictureBoxCarImage.Size = new System.Drawing.Size(231, 150);
            this.pictureBoxCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarImage.TabIndex = 24;
            this.pictureBoxCarImage.TabStop = false;
            // 
            // groupCarDetails
            // 
            this.groupCarDetails.Controls.Add(this.lblHeight);
            this.groupCarDetails.Controls.Add(this.txtHeight);
            this.groupCarDetails.Controls.Add(this.label4);
            this.groupCarDetails.Controls.Add(this.lblWeight);
            this.groupCarDetails.Controls.Add(this.txtWeight);
            this.groupCarDetails.Controls.Add(this.lblSolved);
            this.groupCarDetails.Controls.Add(this.txtAvailable);
            this.groupCarDetails.Controls.Add(this.lblLocation);
            this.groupCarDetails.Controls.Add(this.txtLocation);
            this.groupCarDetails.Controls.Add(this.lblDescription);
            this.groupCarDetails.Controls.Add(this.txtDescription);
            this.groupCarDetails.Controls.Add(this.lblSuspect);
            this.groupCarDetails.Controls.Add(this.txtName);
            this.groupCarDetails.Controls.Add(this.lblAge);
            this.groupCarDetails.Controls.Add(this.txtAge);
            this.groupCarDetails.Controls.Add(this.lblYear);
            this.groupCarDetails.Controls.Add(this.lblManufacturer);
            this.groupCarDetails.Controls.Add(this.txtYear);
            this.groupCarDetails.Controls.Add(this.txtCategory);
            this.groupCarDetails.Location = new System.Drawing.Point(25, 240);
            this.groupCarDetails.Name = "groupCarDetails";
            this.groupCarDetails.Size = new System.Drawing.Size(243, 288);
            this.groupCarDetails.TabIndex = 23;
            this.groupCarDetails.TabStop = false;
            this.groupCarDetails.Text = "Criminal Details";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(6, 135);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(45, 12);
            this.lblHeight.TabIndex = 18;
            this.lblHeight.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(7, 150);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 16;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(117, 135);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(48, 12);
            this.lblWeight.TabIndex = 15;
            this.lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(119, 151);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 14;
            // 
            // lblSolved
            // 
            this.lblSolved.AutoSize = true;
            this.lblSolved.Location = new System.Drawing.Point(117, 189);
            this.lblSolved.Name = "lblSolved";
            this.lblSolved.Size = new System.Drawing.Size(55, 12);
            this.lblSolved.TabIndex = 13;
            this.lblSolved.Text = "Solved?";
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(119, 205);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(95, 20);
            this.txtAvailable.TabIndex = 12;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(5, 189);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(60, 12);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(5, 204);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(102, 20);
            this.txtLocation.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 247);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 12);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(0, 262);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(237, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // lblSuspect
            // 
            this.lblSuspect.AutoSize = true;
            this.lblSuspect.Location = new System.Drawing.Point(4, 84);
            this.lblSuspect.Name = "lblSuspect";
            this.lblSuspect.Size = new System.Drawing.Size(55, 12);
            this.lblSuspect.TabIndex = 4;
            this.lblSuspect.Text = "Suspect";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(5, 99);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(102, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(116, 84);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 12);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(119, 99);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(102, 20);
            this.txtAge.TabIndex = 6;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(116, 28);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(33, 12);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(13, 28);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(93, 12);
            this.lblManufacturer.TabIndex = 3;
            this.lblManufacturer.Text = "Alleged Crime";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(119, 44);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(104, 20);
            this.txtYear.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(7, 43);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(100, 20);
            this.txtCategory.TabIndex = 0;
            // 
            // lblPoliceDatabase
            // 
            this.lblPoliceDatabase.AutoSize = true;
            this.lblPoliceDatabase.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliceDatabase.Location = new System.Drawing.Point(396, 141);
            this.lblPoliceDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoliceDatabase.Name = "lblPoliceDatabase";
            this.lblPoliceDatabase.Size = new System.Drawing.Size(272, 26);
            this.lblPoliceDatabase.TabIndex = 32;
            this.lblPoliceDatabase.Text = "MBNR Crime Bureau";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(470, 502);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(158, 34);
            this.btnReload.TabIndex = 33;
            this.btnReload.Text = "Refresh Datagrid";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // ViewRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 595);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblPoliceDatabase);
            this.Controls.Add(this.btnUpdateCriminal);
            this.Controls.Add(this.dataGridViewCriminals);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBoxCarImage);
            this.Controls.Add(this.groupCarDetails);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewRecords";
            this.Text = "ViewRecords";
            this.Load += new System.EventHandler(this.ViewRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriminals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage)).EndInit();
            this.groupCarDetails.ResumeLayout(false);
            this.groupCarDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCriminal;
        private System.Windows.Forms.DataGridView dataGridViewCriminals;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBoxCarImage;
        private System.Windows.Forms.GroupBox groupCarDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblSolved;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblSuspect;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblPoliceDatabase;
        private System.Windows.Forms.Button btnReload;
    }
}