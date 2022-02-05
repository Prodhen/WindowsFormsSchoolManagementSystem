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
    public partial class ParentInformation : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public ParentInformation()
        {
            InitializeComponent();
        }

        private void ParentInformation_Load(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Parent", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridParentInformation.DataSource = dt;
            }
        }

        private void btnParentAdd_Click(object sender, EventArgs e)
        {
            if (txtFatherName.Text != "" && txtNIDNumber.Text != "")
            {
            using (con = new SqlConnection(cs))
            {

             
                int rowCount = 0;
                SqlTransaction tran = null;
                con.Open();
                tran = con.BeginTransaction();
                SqlCommand cmd = con.CreateCommand();
     
             
                cmd.CommandType = CommandType.Text;
               cmd.CommandText = "INSERT INTO Parent(Name,NID,Phone,Email,Occupation,Income,Address)VALUES(@name,@nid,@phone,@email,@occupation,@income,@address)";

                
                cmd.Parameters.AddWithValue("@name", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@nid", txtNIDNumber.Text).ToString();
                cmd.Parameters.AddWithValue("@phone", txtFatherPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtFatherEmail.Text);
                cmd.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                cmd.Parameters.AddWithValue("@income", txtFatherIncom.Text).ToString();
                cmd.Parameters.AddWithValue("@address", txtFatherAddress.Text);


          
                cmd.Transaction = tran;
                rowCount = cmd.ExecuteNonQuery();

              
                if (rowCount > 0)
                {
                    tran.Commit();
                    MessageBox.Show("Data Inserted Successfully");
                    adapter = new SqlDataAdapter("SELECT * FROM Parent", con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridParentInformation.DataSource = dt;
                }
                else
                {
                    tran.Rollback();
                    MessageBox.Show("Erorr");


                }
            }
        }
            
            else
            {
               MessageBox.Show("Please enter your info");
            }
            txtFatherName.Text = "";
            txtNIDNumber.Text = "";
            txtFatherPhone.Text = "";
            txtFatherEmail.Text = "";
            txtOccupation.Text = "";
            txtFatherIncom.Text = "";
            txtFatherAddress.Text = "";
            lblParentsId.Text = "";
        }

        private void btnParentUpdate_Click(object sender, EventArgs e)
        {

            if (txtFatherName.Text != "" && txtNIDNumber.Text != "")
            {
                using (con = new SqlConnection(cs))
                {
                    cmd = new SqlCommand("UPDATE Parent SET Name=@name,NID=@nid,Phone=@phone,Email=@email,Occupation=@occupation,Income=@income,Address=@address WHERE ParentID = @parentsid", con);
                    cmd.Parameters.AddWithValue("@name", txtFatherName.Text);
                    cmd.Parameters.AddWithValue("@nid", txtNIDNumber.Text);
                    cmd.Parameters.AddWithValue("@phone", txtFatherPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtFatherEmail.Text);
                    cmd.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                    cmd.Parameters.AddWithValue("@income", txtFatherIncom.Text);
                    cmd.Parameters.AddWithValue("@address", txtFatherAddress.Text);
                    cmd.Parameters.AddWithValue("@parentsid", lblParentsId.Text);
                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Updated Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Parent", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridParentInformation.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your info");
            }
            txtFatherName.Text = "";
            txtNIDNumber.Text = "";
            txtFatherPhone.Text = "";
            txtFatherEmail.Text = "";
            txtOccupation.Text = "";
            txtFatherIncom.Text = "";
            txtFatherAddress.Text = "";
            lblParentsId.Text = "";





            btnParentAdd.Show();
            btnParentDelete.Hide();
            btnParentUpdate.Hide();
           btnCancel.Hide();







        }

        private void btnParentDelete_Click(object sender, EventArgs e)
        {

            if (lblParentsId.Text != "")
            {
                using (con = new SqlConnection(cs))
                {
                    cmd = new SqlCommand("DELETE FROM Parent WHERE ParentID = @parentsid", con);
                    cmd.Parameters.AddWithValue("@parentsid", lblParentsId.Text);
                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Delted Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Parent", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridParentInformation.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your info");
            }

  


            txtFatherName.Text = "";
            txtNIDNumber.Text = "";
            txtFatherPhone.Text = "";
            txtFatherEmail.Text = "";
            txtOccupation.Text = "";
            txtFatherIncom.Text = "";
            txtFatherAddress.Text = "";
            lblParentsId.Text = "";

            btnParentAdd.Show();
            btnParentDelete.Hide();
            btnParentUpdate.Hide();
            btnCancel.Hide();




        }

        private void dataGridParentInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFatherName.Text = this.dataGridParentInformation.CurrentRow.Cells["Name"].Value.ToString();
            txtNIDNumber.Text = this.dataGridParentInformation.CurrentRow.Cells["NID"].Value.ToString();
            txtFatherPhone.Text = this.dataGridParentInformation.CurrentRow.Cells["Phone"].Value.ToString();
            txtFatherEmail.Text = this.dataGridParentInformation.CurrentRow.Cells["Email"].Value.ToString();
            txtOccupation.Text = this.dataGridParentInformation.CurrentRow.Cells["Occupation"].Value.ToString();
            txtFatherIncom.Text = this.dataGridParentInformation.CurrentRow.Cells["Income"].Value.ToString();
            txtFatherAddress.Text = this.dataGridParentInformation.CurrentRow.Cells["Address"].Value.ToString();
            lblParentsId.Text = this.dataGridParentInformation.CurrentRow.Cells["ParentID"].Value.ToString();

            btnParentAdd.Hide();
            btnParentDelete.Show();
            btnParentUpdate.Show();
            btnCancel.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFatherName.Text = "";
            txtNIDNumber.Text = "";
            txtFatherPhone.Text = "";
            txtFatherEmail.Text = "";
            txtOccupation.Text = "";
            txtFatherIncom.Text = "";
            txtFatherAddress.Text = "";
            lblParentsId.Text = "";

            btnParentAdd.Show();
            btnParentDelete.Hide();
            btnParentUpdate.Hide();
            btnCancel.Hide();


        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapter = new SqlDataAdapter("select * from Parent where Name like '" + textBoxSearch.Text + "%'", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridParentInformation.DataSource = dt;
            con.Close();
        }
    }
}
