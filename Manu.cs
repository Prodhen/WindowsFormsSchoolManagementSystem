using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Arosh
{
    public partial class Manu : Form
    {
        public Manu()
        {
            InitializeComponent();
        }
        Teacher t;

        private void toolStripAddTeacher_Click(object sender, EventArgs e)
        {
            if (t==null)
            {
                t = new Teacher();
                t.MdiParent=this;
                t.FormClosed += new FormClosedEventHandler(T_FormClosed);
                t.Show();

            }
            //Teacher teacher = new Teacher();
            //teacher.MdiParent = Manu.ActiveForm;
            //teacher.Show();
            //ClassInformation classInformation = new ClassInformation();
            //classInformation.Show();

        }

        private void T_FormClosed(object sender, FormClosedEventArgs e)
        {
            t = null;
        }

        ClassInformation c;

        private void toolStripMenuItemClass_Click(object sender, EventArgs e)
        {
            ClassInformation classInformation = new ClassInformation();
            classInformation.MdiParent = Manu.ActiveForm;
            classInformation.Show();
            //Teacher teacher = new Teacher();
            //teacher.MdiParent = Manu.ActiveForm;
            //teacher.Hide();

            if (c == null)
            {
                c = new ClassInformation();
                c.MdiParent = this;
                c.FormClosed += new FormClosedEventHandler(C_FormClosed);
                c.Show();

            }


        }

        private void C_FormClosed(object sender, FormClosedEventArgs e)
        {
            c = null;
        }

        ParentInformation p;
        private void toolStripMenuItemParent_Click(object sender, EventArgs e)
        {
            //ParentInformation parentInformation = new ParentInformation();
            //parentInformation.MdiParent = Manu.ActiveForm;
            //parentInformation.Show();

            if (p == null)
            {
                p= new ParentInformation();
                p.MdiParent = this;
                p.FormClosed += new FormClosedEventHandler(P_FormClosed);
                p.Show();

            }

        }

        private void P_FormClosed(object sender, FormClosedEventArgs e)
        {
            p = null;
        }
        FormStudentReg s;

        private void toolStripMenuItemStudentReg_Click(object sender, EventArgs e)
        {
            //FormStudentReg formStudentReg = new FormStudentReg();
            //formStudentReg.MdiParent = Manu.ActiveForm;
            //formStudentReg.Show();


            if (s == null)
            {
                s = new FormStudentReg();
                s.MdiParent = this;
                s.FormClosed += new FormClosedEventHandler(S_FormClosed);
                s.Show();

            }

        }

        private void S_FormClosed(object sender, FormClosedEventArgs e)
        {
            s = null;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        TeacherReport TR;
        private void toolStripTeacherReport_Click(object sender, EventArgs e)
        {

            if (TR == null)
            {
                TR = new TeacherReport();
                TR.MdiParent = this;
                TR.FormClosed += new FormClosedEventHandler(TR_FormClosed);
                TR.Show();

            }

        }

        private void TR_FormClosed(object sender, FormClosedEventArgs e)
        {
            TR = null;
        }
        ParentReport PR;

        private void toolStripParentReport_Click(object sender, EventArgs e)
        {
            if (PR == null)
            {
                PR = new ParentReport();
                PR.MdiParent = this;
                PR.FormClosed += new FormClosedEventHandler(PR_FormClosed);
                PR.Show();

            }

        }

        private void PR_FormClosed(object sender, FormClosedEventArgs e)
        {
            PR = null;
        }
        ClassReport CR;
        
        private void toolStripClass_Click(object sender, EventArgs e)
        {
            if (PR == null)
            {
                CR = new ClassReport();
                CR.MdiParent = this;
                CR.FormClosed += new FormClosedEventHandler(CR_FormClosed);
                CR.Show();

            }

        }

        private void CR_FormClosed(object sender, FormClosedEventArgs e)
        {
            CR = null;
        }

        StutdentReportC st;

        private void toolStripStudentReport_Click(object sender, EventArgs e)
        {
            if (st == null)
            {
                st = new StutdentReportC();
                st.MdiParent = this;
                st.FormClosed += new FormClosedEventHandler(St_FormClosed);
                st.Show();

            }

        }

        private void St_FormClosed(object sender, FormClosedEventArgs e)
        {
            st = null;
        }
    }
}
