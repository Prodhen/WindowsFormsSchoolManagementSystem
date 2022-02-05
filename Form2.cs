using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Arosh
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            //if (ValidateChildren(ValidationConstraints.Enabled))
            //{

            //}
            string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
            //SqlConnection con;
            //SqlCommand cmd;
            //SqlDataAdapter adapter;
            //DataTable dt;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from User1 WHERE Name=@username AND Password=@password", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Manu manu = new Manu();
                    manu.Show();

                }
                else
                {
                    MessageBox.Show("Your User Name or Password Incorrect!!!");
                }

            }



        }

        //private void textBox1_Validating(object sender, CancelEventArgs e)
        //{
        //    if (textBox1.Text !="Arosh")
        //    {
        //        e.Cancel = true;
        //        textBox1.Focus();
        //        errorProvider1.SetError(textBox1, "Please enter correct name");

        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //        errorProvider1.SetError(textBox1, null);
        //    }

        //}
    }
}
