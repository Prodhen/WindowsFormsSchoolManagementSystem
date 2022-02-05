
namespace School_Arosh
{
    partial class Manu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripAddTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemParent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStudentReg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuViewReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTeacherReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripClass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripParentReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStudentReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddTeacher,
            this.toolStripMenuItemClass,
            this.toolStripMenuItemParent,
            this.toolStripMenuItemStudentReg,
            this.toolStripMenuViewReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripAddTeacher
            // 
            this.toolStripAddTeacher.Name = "toolStripAddTeacher";
            this.toolStripAddTeacher.Size = new System.Drawing.Size(141, 32);
            this.toolStripAddTeacher.Text = "Add Teacher";
            this.toolStripAddTeacher.Click += new System.EventHandler(this.toolStripAddTeacher_Click);
            // 
            // toolStripMenuItemClass
            // 
            this.toolStripMenuItemClass.Name = "toolStripMenuItemClass";
            this.toolStripMenuItemClass.Size = new System.Drawing.Size(115, 32);
            this.toolStripMenuItemClass.Text = "Add Class";
            this.toolStripMenuItemClass.Click += new System.EventHandler(this.toolStripMenuItemClass_Click);
            // 
            // toolStripMenuItemParent
            // 
            this.toolStripMenuItemParent.Name = "toolStripMenuItemParent";
            this.toolStripMenuItemParent.Size = new System.Drawing.Size(130, 32);
            this.toolStripMenuItemParent.Text = "Add Parent";
            this.toolStripMenuItemParent.Click += new System.EventHandler(this.toolStripMenuItemParent_Click);
            // 
            // toolStripMenuItemStudentReg
            // 
            this.toolStripMenuItemStudentReg.Name = "toolStripMenuItemStudentReg";
            this.toolStripMenuItemStudentReg.Size = new System.Drawing.Size(220, 32);
            this.toolStripMenuItemStudentReg.Text = "Student Registration";
            this.toolStripMenuItemStudentReg.Click += new System.EventHandler(this.toolStripMenuItemStudentReg_Click);
            // 
            // toolStripMenuViewReport
            // 
            this.toolStripMenuViewReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTeacherReport,
            this.toolStripClass,
            this.toolStripParentReport,
            this.toolStripStudentReport});
            this.toolStripMenuViewReport.Name = "toolStripMenuViewReport";
            this.toolStripMenuViewReport.Size = new System.Drawing.Size(141, 32);
            this.toolStripMenuViewReport.Text = "View Report";
            // 
            // toolStripTeacherReport
            // 
            this.toolStripTeacherReport.Name = "toolStripTeacherReport";
            this.toolStripTeacherReport.Size = new System.Drawing.Size(276, 32);
            this.toolStripTeacherReport.Text = "Teacher Information";
            this.toolStripTeacherReport.Click += new System.EventHandler(this.toolStripTeacherReport_Click);
            // 
            // toolStripClass
            // 
            this.toolStripClass.Name = "toolStripClass";
            this.toolStripClass.Size = new System.Drawing.Size(276, 32);
            this.toolStripClass.Text = "Class Information";
            this.toolStripClass.Click += new System.EventHandler(this.toolStripClass_Click);
            // 
            // toolStripParentReport
            // 
            this.toolStripParentReport.Name = "toolStripParentReport";
            this.toolStripParentReport.Size = new System.Drawing.Size(276, 32);
            this.toolStripParentReport.Text = "Parent Information";
            this.toolStripParentReport.Click += new System.EventHandler(this.toolStripParentReport_Click);
            // 
            // toolStripStudentReport
            // 
            this.toolStripStudentReport.Name = "toolStripStudentReport";
            this.toolStripStudentReport.Size = new System.Drawing.Size(276, 32);
            this.toolStripStudentReport.Text = "StudentInformation";
            this.toolStripStudentReport.Click += new System.EventHandler(this.toolStripStudentReport_Click);
            // 
            // Manu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 519);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Manu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddTeacher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClass;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemParent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStudentReg;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuViewReport;
        private System.Windows.Forms.ToolStripMenuItem toolStripTeacherReport;
        private System.Windows.Forms.ToolStripMenuItem toolStripClass;
        private System.Windows.Forms.ToolStripMenuItem toolStripParentReport;
        private System.Windows.Forms.ToolStripMenuItem toolStripStudentReport;
    }
}