using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.IO;

namespace School_Arosh
{
    public partial class FormStudentReg : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
       
        SqlDataAdapter adapter;
        DataTable dt;
        DataRow dr;
        DataRow dr1;
        string gender;
        string imageLocation = "";
        public FormStudentReg()
        {
            InitializeComponent();
            GetClassNameFromDatabase();
            GetParentNIDromDatabase();
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";

        }

        private void FormStudentReg_Load(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Student", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridOutput.DataSource = dt;
            }

        }
        public void GetClassNameFromDatabase()
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Class", con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Choose Class Name" };
                dt.Rows.InsertAt(dr, 0);

                comboBoxClassName.ValueMember = "ClassId";
                comboBoxClassName.DisplayMember = "Name";

                comboBoxClassName.DataSource = dt;

                con.Close();
            }
        }
        public void GetParentNIDromDatabase()
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Parent", con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dr1 = dt.NewRow();
                dr1.ItemArray = new object[] { 0, "Select NID No" };
                dt.Rows.InsertAt(dr1, 0);

                comboBoxParentsNID.ValueMember = "ParentID";
                comboBoxParentsNID.DisplayMember = "NID";

                comboBoxParentsNID.DataSource = dt;

                con.Close();
            }
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && dateOfbirth.Text != "")
            {
                using (con = new SqlConnection(cs))
                {

                    var imagePath = "";

                    File.Copy(imageLocation, Path.Combine(@"C:\Uploads", Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
                    imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());



                    cmd = new SqlCommand("INSERT INTO Student (firstName,lastName, Gender, DOB,Address,Shift,ClassID,ParentsNID,Image) VALUES (@firstName,@lastName, @gender, @dob,@address,@shift,@className,@parentsNID,@image)", con);
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", dateOfbirth.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@className", comboBoxClassName.Text);
                  

                    cmd.Parameters.AddWithValue("@shift", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@parentsNID", comboBoxParentsNID.Text);
                    cmd.Parameters.AddWithValue("@image", imagePath);

                    con.Open();
                   
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                      
                        MessageBox.Show("Data Inserted Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Student", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridOutput.DataSource = dt;
                    }

                }
            }
            else
            {
                
                MessageBox.Show("Please enter your info");

            }




        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                pictureOfStudent.ImageLocation = imageLocation;
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && comboBoxParentsNID.Text != "")
            {
                using (con = new SqlConnection(cs))
                {
                    var imagePath = "";

                    File.Copy(imageLocation, Path.Combine(@"C:\Uploads", Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
                    imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());



                    cmd = new SqlCommand("UPDATE Student SET firstName=@firstName,lastName=@lastName, Gender=@gender, DOB=@dob,Address=@address,Shift=@shift,ClassID=@className,ParentsNID=@parentsNID,Image=@image Where StudentID = @studentid", con);
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", dateOfbirth.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@className", comboBoxClassName.Text);
                    cmd.Parameters.AddWithValue("@shift", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@parentsNID", comboBoxParentsNID.Text);
                    cmd.Parameters.AddWithValue("@image", imagePath);
                    cmd.Parameters.AddWithValue("@studentid", lblStudentid.Text);

                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Updated Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Student", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridOutput.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your info");
            }



            txtFirstName.Text = "";
            txtLastName.Text = "";
            //gender
            dateOfbirth.Text = "";
            txtAddress.Text = "";
            comboBoxClassName.Text = "";
            comboBox1.Text = "";
            comboBoxParentsNID.Text = "";
            pictureOfStudent.Image = null;


            btnSave.Show();
            btnUpdateStudent.Hide();
            btnDeleteStudent.Hide();
            btnCancel.Hide();



        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (lblStudentid.Text != "")
            {
                using (con = new SqlConnection(cs))
                {
                    cmd = new SqlCommand("DELETE FROM Student WHERE StudentID = @studentid", con);
                    cmd.Parameters.AddWithValue("@studentid", lblStudentid.Text);
                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Delted Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Student", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridOutput.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your info");
            }

   



      


            txtFirstName.Text = "";
            txtLastName.Text= "";
            //gender
            dateOfbirth.Text = "";
            txtAddress.Text = "";
            comboBoxClassName.Text = "";
            comboBox1.Text = "";
            comboBoxParentsNID.Text = "";
            pictureOfStudent.Image = null;


            btnSave.Show();
            btnUpdateStudent.Hide();
            btnDeleteStudent.Hide();
            btnCancel.Hide();

        }

        private void dataGridOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstName.Text = this.dataGridOutput.CurrentRow.Cells["firstName"].Value.ToString();
            txtLastName.Text = this.dataGridOutput.CurrentRow.Cells["lastName"].Value.ToString();
            //gender
            if (this.dataGridOutput.CurrentRow.Cells["Gender"].Value.ToString() == "Male")
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }


            dateOfbirth.Text = this.dataGridOutput.CurrentRow.Cells["DOB"].Value.ToString();
            txtAddress.Text = this.dataGridOutput.CurrentRow.Cells["Address"].Value.ToString();
            comboBoxClassName.Text = this.dataGridOutput.CurrentRow.Cells["ClassID"].Value.ToString();
            comboBox1.Text = this.dataGridOutput.CurrentRow.Cells["Shift"].Value.ToString();
            comboBoxParentsNID.Text = this.dataGridOutput.CurrentRow.Cells["ParentsNID"].Value.ToString();
            pictureOfStudent.Image = null;
            lblStudentid.Text = this.dataGridOutput.CurrentRow.Cells["StudentID"].Value.ToString();

            btnSave.Hide();
            btnUpdateStudent.Show();
            btnDeleteStudent.Show();
            btnCancel.Show();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            //gender
            dateOfbirth.Text = "";
            txtAddress.Text = "";
            comboBoxClassName.Text = "";
            comboBox1.Text = "";
            comboBoxParentsNID.Text = "";
            pictureOfStudent.Image = null;


            btnSave.Show();
            btnUpdateStudent.Hide();
            btnDeleteStudent.Hide();
            btnCancel.Hide();

        }

        private void textBoxSerch_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapter = new SqlDataAdapter("select * from Student where lastName like '" + textBoxSerch.Text + "%'", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridOutput.DataSource = dt;
            con.Close();
        }
    }
}
