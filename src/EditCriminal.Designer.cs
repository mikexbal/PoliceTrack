namespace PoliceDatabaseProgam
{
    partial class EditCriminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCriminal));
            this.txtBoxUWeight = new System.Windows.Forms.TextBox();
            this.bttnUWeight = new System.Windows.Forms.Button();
            this.bttnChangeCase = new System.Windows.Forms.Button();
            this.txtBoxUName = new System.Windows.Forms.TextBox();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.txtBoxULocation = new System.Windows.Forms.TextBox();
            this.bttnULocation = new System.Windows.Forms.Button();
            this.txtBoxUYear = new System.Windows.Forms.TextBox();
            this.bttnUYear = new System.Windows.Forms.Button();
            this.txtBoxUHeight = new System.Windows.Forms.TextBox();
            this.bttnUHeight = new System.Windows.Forms.Button();
            this.dataGridViewCriminals = new System.Windows.Forms.DataGridView();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnRecordDescription = new System.Windows.Forms.Button();
            this.btnUpdateAge = new System.Windows.Forms.Button();
            this.descriptionInfoTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.lblPoliceDatabase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriminals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxUWeight
            // 
            this.txtBoxUWeight.Location = new System.Drawing.Point(86, 588);
            this.txtBoxUWeight.Name = "txtBoxUWeight";
            this.txtBoxUWeight.Size = new System.Drawing.Size(160, 20);
            this.txtBoxUWeight.TabIndex = 44;
            // 
            // bttnUWeight
            // 
            this.bttnUWeight.Location = new System.Drawing.Point(86, 544);
            this.bttnUWeight.Name = "bttnUWeight";
            this.bttnUWeight.Size = new System.Drawing.Size(160, 38);
            this.bttnUWeight.TabIndex = 43;
            this.bttnUWeight.Text = "Update Suspect Weight";
            this.bttnUWeight.UseVisualStyleBackColor = true;
            this.bttnUWeight.Click += new System.EventHandler(this.bttnUWeight_Click_1);
            // 
            // bttnChangeCase
            // 
            this.bttnChangeCase.Location = new System.Drawing.Point(272, 544);
            this.bttnChangeCase.Name = "bttnChangeCase";
            this.bttnChangeCase.Size = new System.Drawing.Size(160, 64);
            this.bttnChangeCase.TabIndex = 42;
            this.bttnChangeCase.Text = "Re Open/Close Case";
            this.bttnChangeCase.UseVisualStyleBackColor = true;
            this.bttnChangeCase.Click += new System.EventHandler(this.bttnChangeCase_Click);
            // 
            // txtBoxUName
            // 
            this.txtBoxUName.Location = new System.Drawing.Point(86, 421);
            this.txtBoxUName.Name = "txtBoxUName";
            this.txtBoxUName.Size = new System.Drawing.Size(160, 20);
            this.txtBoxUName.TabIndex = 41;
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(86, 377);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(160, 38);
            this.btnUpdateName.TabIndex = 40;
            this.btnUpdateName.Text = "Update Suspect";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // txtBoxULocation
            // 
            this.txtBoxULocation.Location = new System.Drawing.Point(465, 505);
            this.txtBoxULocation.Name = "txtBoxULocation";
            this.txtBoxULocation.Size = new System.Drawing.Size(160, 20);
            this.txtBoxULocation.TabIndex = 39;
            // 
            // bttnULocation
            // 
            this.bttnULocation.Location = new System.Drawing.Point(465, 461);
            this.bttnULocation.Name = "bttnULocation";
            this.bttnULocation.Size = new System.Drawing.Size(160, 38);
            this.bttnULocation.TabIndex = 38;
            this.bttnULocation.Text = "Update Location";
            this.bttnULocation.UseVisualStyleBackColor = true;
            this.bttnULocation.Click += new System.EventHandler(this.bttnULocation_Click_1);
            // 
            // txtBoxUYear
            // 
            this.txtBoxUYear.Location = new System.Drawing.Point(272, 505);
            this.txtBoxUYear.Name = "txtBoxUYear";
            this.txtBoxUYear.Size = new System.Drawing.Size(160, 20);
            this.txtBoxUYear.TabIndex = 37;
            // 
            // bttnUYear
            // 
            this.bttnUYear.Location = new System.Drawing.Point(272, 461);
            this.bttnUYear.Name = "bttnUYear";
            this.bttnUYear.Size = new System.Drawing.Size(160, 38);
            this.bttnUYear.TabIndex = 36;
            this.bttnUYear.Text = "Update Year";
            this.bttnUYear.UseVisualStyleBackColor = true;
            this.bttnUYear.Click += new System.EventHandler(this.bttnUYear_Click_1);
            // 
            // txtBoxUHeight
            // 
            this.txtBoxUHeight.Location = new System.Drawing.Point(86, 505);
            this.txtBoxUHeight.Name = "txtBoxUHeight";
            this.txtBoxUHeight.Size = new System.Drawing.Size(160, 20);
            this.txtBoxUHeight.TabIndex = 35;
            // 
            // bttnUHeight
            // 
            this.bttnUHeight.Location = new System.Drawing.Point(86, 461);
            this.bttnUHeight.Name = "bttnUHeight";
            this.bttnUHeight.Size = new System.Drawing.Size(160, 38);
            this.bttnUHeight.TabIndex = 34;
            this.bttnUHeight.Text = "Update Suspect Height";
            this.bttnUHeight.UseVisualStyleBackColor = true;
            this.bttnUHeight.Click += new System.EventHandler(this.bttnUHeight_Click_1);
            // 
            // dataGridViewCriminals
            // 
            this.dataGridViewCriminals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCriminals.Location = new System.Drawing.Point(12, 101);
            this.dataGridViewCriminals.Name = "dataGridViewCriminals";
            this.dataGridViewCriminals.ReadOnly = true;
            this.dataGridViewCriminals.Size = new System.Drawing.Size(655, 160);
            this.dataGridViewCriminals.TabIndex = 33;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(272, 421);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(160, 20);
            this.txtAge.TabIndex = 32;
            // 
            // btnRecordDescription
            // 
            this.btnRecordDescription.Location = new System.Drawing.Point(464, 377);
            this.btnRecordDescription.Name = "btnRecordDescription";
            this.btnRecordDescription.Size = new System.Drawing.Size(160, 38);
            this.btnRecordDescription.TabIndex = 31;
            this.btnRecordDescription.Text = "Update Crime Description";
            this.btnRecordDescription.UseVisualStyleBackColor = true;
            this.btnRecordDescription.Click += new System.EventHandler(this.btnRecordDescription_Click_1);
            // 
            // btnUpdateAge
            // 
            this.btnUpdateAge.Location = new System.Drawing.Point(272, 377);
            this.btnUpdateAge.Name = "btnUpdateAge";
            this.btnUpdateAge.Size = new System.Drawing.Size(160, 38);
            this.btnUpdateAge.TabIndex = 30;
            this.btnUpdateAge.Text = "Update Suspect Age";
            this.btnUpdateAge.UseVisualStyleBackColor = true;
            this.btnUpdateAge.Click += new System.EventHandler(this.btnUpdateAge_Click_1);
            // 
            // descriptionInfoTextBox
            // 
            this.descriptionInfoTextBox.Location = new System.Drawing.Point(465, 421);
            this.descriptionInfoTextBox.Name = "descriptionInfoTextBox";
            this.descriptionInfoTextBox.Size = new System.Drawing.Size(159, 20);
            this.descriptionInfoTextBox.TabIndex = 29;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(464, 544);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(160, 64);
            this.submitButton.TabIndex = 28;
            this.submitButton.Text = "Save Changes";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // lblPoliceDatabase
            // 
            this.lblPoliceDatabase.AutoSize = true;
            this.lblPoliceDatabase.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliceDatabase.Location = new System.Drawing.Point(201, 264);
            this.lblPoliceDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoliceDatabase.Name = "lblPoliceDatabase";
            this.lblPoliceDatabase.Size = new System.Drawing.Size(272, 26);
            this.lblPoliceDatabase.TabIndex = 46;
            this.lblPoliceDatabase.Text = "MBNR Crime Bureau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Edit The Information About A Case";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "All Fields Must Be Dealt with";
            // 
            // EditCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 645);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPoliceDatabase);
            this.Controls.Add(this.txtBoxUWeight);
            this.Controls.Add(this.bttnUWeight);
            this.Controls.Add(this.bttnChangeCase);
            this.Controls.Add(this.txtBoxUName);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.txtBoxULocation);
            this.Controls.Add(this.bttnULocation);
            this.Controls.Add(this.txtBoxUYear);
            this.Controls.Add(this.bttnUYear);
            this.Controls.Add(this.txtBoxUHeight);
            this.Controls.Add(this.bttnUHeight);
            this.Controls.Add(this.dataGridViewCriminals);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnRecordDescription);
            this.Controls.Add(this.btnUpdateAge);
            this.Controls.Add(this.descriptionInfoTextBox);
            this.Controls.Add(this.submitButton);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditCriminal";
            this.Text = "EditCriminal";
            this.Load += new System.EventHandler(this.EditCriminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriminals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxUWeight;
        private System.Windows.Forms.Button bttnUWeight;
        private System.Windows.Forms.Button bttnChangeCase;
        private System.Windows.Forms.TextBox txtBoxUName;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.TextBox txtBoxULocation;
        private System.Windows.Forms.Button bttnULocation;
        private System.Windows.Forms.TextBox txtBoxUYear;
        private System.Windows.Forms.Button bttnUYear;
        private System.Windows.Forms.TextBox txtBoxUHeight;
        private System.Windows.Forms.Button bttnUHeight;
        private System.Windows.Forms.DataGridView dataGridViewCriminals;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnRecordDescription;
        private System.Windows.Forms.Button btnUpdateAge;
        private System.Windows.Forms.TextBox descriptionInfoTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label lblPoliceDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}