
namespace School_Arosh
{
    partial class FormStudentReg
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
            this.lblStudentReg = new System.Windows.Forms.Label();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dataGridOutput = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.dateOfbirth = new System.Windows.Forms.DateTimePicker();
            this.pictureOfStudent = new System.Windows.Forms.PictureBox();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.lblParentNID = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxClassName = new System.Windows.Forms.ComboBox();
            this.comboBoxParentsNID = new System.Windows.Forms.ComboBox();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.lblStudentid = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxSerch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentReg
            // 
            this.lblStudentReg.AutoSize = true;
            this.lblStudentReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentReg.Location = new System.Drawing.Point(212, 3);
            this.lblStudentReg.Name = "lblStudentReg";
            this.lblStudentReg.Size = new System.Drawing.Size(433, 46);
            this.lblStudentReg.TabIndex = 0;
            this.lblStudentReg.Text = "Registration 2021-2022";
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.Location = new System.Drawing.Point(333, 48);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(200, 25);
            this.lblStudentInfo.TabIndex = 1;
            this.lblStudentInfo.Text = "Student Information";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(88, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(87, 132);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(86, 198);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(81, 13);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(88, 228);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(212, 94);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(114, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(212, 133);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(114, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(212, 228);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(114, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // dataGridOutput
            // 
            this.dataGridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOutput.Location = new System.Drawing.Point(389, 88);
            this.dataGridOutput.Name = "dataGridOutput";
            this.dataGridOutput.Size = new System.Drawing.Size(575, 160);
            this.dataGridOutput.TabIndex = 10;
            this.dataGridOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOutput_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(143, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(87, 164);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 13);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(212, 164);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 13;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(267, 164);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 14;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // dateOfbirth
            // 
            this.dateOfbirth.Location = new System.Drawing.Point(212, 192);
            this.dateOfbirth.Name = "dateOfbirth";
            this.dateOfbirth.Size = new System.Drawing.Size(114, 20);
            this.dateOfbirth.TabIndex = 15;
            // 
            // pictureOfStudent
            // 
            this.pictureOfStudent.Location = new System.Drawing.Point(212, 331);
            this.pictureOfStudent.Name = "pictureOfStudent";
            this.pictureOfStudent.Size = new System.Drawing.Size(114, 70);
            this.pictureOfStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOfStudent.TabIndex = 16;
            this.pictureOfStudent.TabStop = false;
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.Location = new System.Drawing.Point(90, 356);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(94, 23);
            this.btnUploadPicture.TabIndex = 17;
            this.btnUploadPicture.Text = "Upload Picture";
            this.btnUploadPicture.UseVisualStyleBackColor = true;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // lblParentNID
            // 
            this.lblParentNID.AutoSize = true;
            this.lblParentNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentNID.Location = new System.Drawing.Point(90, 306);
            this.lblParentNID.Name = "lblParentNID";
            this.lblParentNID.Size = new System.Drawing.Size(79, 13);
            this.lblParentNID.TabIndex = 18;
            this.lblParentNID.Text = "Parent\'s NID";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(88, 255);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(73, 13);
            this.lblClassName.TabIndex = 20;
            this.lblClassName.Text = "Class Name";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(91, 280);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(33, 13);
            this.lblShift.TabIndex = 22;
            this.lblShift.Text = "Shift";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Morning",
            "Mid-Day"});
            this.comboBox1.Location = new System.Drawing.Point(212, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // comboBoxClassName
            // 
            this.comboBoxClassName.FormattingEnabled = true;
            this.comboBoxClassName.Location = new System.Drawing.Point(212, 251);
            this.comboBoxClassName.Name = "comboBoxClassName";
            this.comboBoxClassName.Size = new System.Drawing.Size(114, 21);
            this.comboBoxClassName.TabIndex = 24;
            // 
            // comboBoxParentsNID
            // 
            this.comboBoxParentsNID.FormattingEnabled = true;
            this.comboBoxParentsNID.Location = new System.Drawing.Point(212, 302);
            this.comboBoxParentsNID.Name = "comboBoxParentsNID";
            this.comboBoxParentsNID.Size = new System.Drawing.Size(114, 21);
            this.comboBoxParentsNID.TabIndex = 25;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.Location = new System.Drawing.Point(192, 421);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(68, 23);
            this.btnUpdateStudent.TabIndex = 26;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Visible = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(265, 422);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 27;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Visible = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // lblStudentid
            // 
            this.lblStudentid.AutoSize = true;
            this.lblStudentid.Location = new System.Drawing.Point(22, 421);
            this.lblStudentid.Name = "lblStudentid";
            this.lblStudentid.Size = new System.Drawing.Size(0, 13);
            this.lblStudentid.TabIndex = 28;
            this.lblStudentid.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(347, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxSerch
            // 
            this.textBoxSerch.Location = new System.Drawing.Point(808, 62);
            this.textBoxSerch.Name = "textBoxSerch";
            this.textBoxSerch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerch.TabIndex = 30;
            this.textBoxSerch.TextChanged += new System.EventHandler(this.textBoxSerch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(656, 66);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(129, 13);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Search By Last Name";
            // 
            // FormStudentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 520);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.textBoxSerch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblStudentid);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.comboBoxParentsNID);
            this.Controls.Add(this.comboBoxClassName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblParentNID);
            this.Controls.Add(this.btnUploadPicture);
            this.Controls.Add(this.pictureOfStudent);
            this.Controls.Add(this.dateOfbirth);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridOutput);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.lblStudentReg);
            this.Name = "FormStudentReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.FormStudentReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentReg;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dataGridOutput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.DateTimePicker dateOfbirth;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.Label lblParentNID;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.PictureBox pictureOfStudent;
        private System.Windows.Forms.ComboBox comboBoxClassName;
        private System.Windows.Forms.ComboBox comboBoxParentsNID;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label lblStudentid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxSerch;
        private System.Windows.Forms.Label lblSearch;
    }
}

