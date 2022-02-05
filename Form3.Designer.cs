
namespace School_Arosh
{
    partial class ClassInformation
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
            this.lblClassInformation = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblAddviser = new System.Windows.Forms.Label();
            this.lblStudentSeat = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtSeatCapacity = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.comboBoxAdviser = new System.Windows.Forms.ComboBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridClassInformation = new System.Windows.Forms.DataGridView();
            this.lblClassId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClassInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassInformation
            // 
            this.lblClassInformation.AutoSize = true;
            this.lblClassInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassInformation.Location = new System.Drawing.Point(305, 9);
            this.lblClassInformation.Name = "lblClassInformation";
            this.lblClassInformation.Size = new System.Drawing.Size(347, 46);
            this.lblClassInformation.TabIndex = 0;
            this.lblClassInformation.Text = "Class Information";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(214, 124);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(39, 13);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "Name";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(211, 198);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(50, 13);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Section";
            // 
            // lblAddviser
            // 
            this.lblAddviser.AutoSize = true;
            this.lblAddviser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddviser.Location = new System.Drawing.Point(211, 234);
            this.lblAddviser.Name = "lblAddviser";
            this.lblAddviser.Size = new System.Drawing.Size(49, 13);
            this.lblAddviser.TabIndex = 3;
            this.lblAddviser.Text = "Adviser";
            // 
            // lblStudentSeat
            // 
            this.lblStudentSeat.AutoSize = true;
            this.lblStudentSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSeat.Location = new System.Drawing.Point(209, 162);
            this.lblStudentSeat.Name = "lblStudentSeat";
            this.lblStudentSeat.Size = new System.Drawing.Size(86, 13);
            this.lblStudentSeat.TabIndex = 4;
            this.lblStudentSeat.Text = "Seat Capacity";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(214, 276);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(59, 13);
            this.lblRoomNo.TabIndex = 5;
            this.lblRoomNo.Text = "Room No";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(328, 124);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 20);
            this.txtClassName.TabIndex = 6;
            // 
            // txtSeatCapacity
            // 
            this.txtSeatCapacity.Location = new System.Drawing.Point(328, 162);
            this.txtSeatCapacity.Name = "txtSeatCapacity";
            this.txtSeatCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtSeatCapacity.TabIndex = 7;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(328, 271);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNo.TabIndex = 10;
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBoxSection.Location = new System.Drawing.Point(328, 198);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSection.TabIndex = 11;
            // 
            // comboBoxAdviser
            // 
            this.comboBoxAdviser.FormattingEnabled = true;
            this.comboBoxAdviser.Location = new System.Drawing.Point(328, 234);
            this.comboBoxAdviser.Name = "comboBoxAdviser";
            this.comboBoxAdviser.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAdviser.TabIndex = 12;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.Location = new System.Drawing.Point(206, 321);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 13;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(313, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(406, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridClassInformation
            // 
            this.dataGridClassInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClassInformation.Location = new System.Drawing.Point(462, 108);
            this.dataGridClassInformation.Name = "dataGridClassInformation";
            this.dataGridClassInformation.Size = new System.Drawing.Size(530, 150);
            this.dataGridClassInformation.TabIndex = 16;
            this.dataGridClassInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClassInformation_CellClick);
            // 
            // lblClassId
            // 
            this.lblClassId.AutoSize = true;
            this.lblClassId.Location = new System.Drawing.Point(24, 371);
            this.lblClassId.Name = "lblClassId";
            this.lblClassId.Size = new System.Drawing.Size(0, 13);
            this.lblClassId.TabIndex = 17;
            this.lblClassId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(507, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cencel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(677, 77);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 19;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(579, 81);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 13);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Serch by  Name";
            // 
            // ClassInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 520);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblClassId);
            this.Controls.Add(this.dataGridClassInformation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.comboBoxAdviser);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.txtSeatCapacity);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblStudentSeat);
            this.Controls.Add(this.lblAddviser);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblClassInformation);
            this.Name = "ClassInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Information";
            this.Load += new System.EventHandler(this.ClassInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClassInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassInformation;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblAddviser;
        private System.Windows.Forms.Label lblStudentSeat;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtSeatCapacity;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.ComboBox comboBoxAdviser;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridClassInformation;
        private System.Windows.Forms.Label lblClassId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}