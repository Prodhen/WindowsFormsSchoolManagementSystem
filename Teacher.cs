using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Arosh
{
    public partial class Teacher : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string imageLocation = "";

        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Teacher", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridTacher.DataSource = dt;
            }
        }







        private void btnAddTacher_Click(object sender, EventArgs e)
        {
            if (txtTeacherName.Text != "" && txtTMobile.Text != "")
            {
                using (con = new SqlConnection(cs))
                {
                    var imagePath = "";

                    File.Copy(imageLocation, Path.Combine(@"C:\Uploads", Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
                    imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());



                    cmd = new SqlCommand("INSERT INTO Teacher(Name,FatherName,Subject,JoiningDate,DOB,Email,Mobile,Address,Image)VALUES(@name,@fatherName,@subject,@joiningDate,@dob,@email,@mobile,@address,@image)", con);
                    cmd.Parameters.AddWithValue("@name", txtTeacherName.Text);
                    cmd.Parameters.AddWithValue("@fatherName", txtTFatherName.Text);
                    cmd.Parameters.AddWithValue("@subject", comboxSubject.Text);
                    cmd.Parameters.AddWithValue("@joiningDate", dateTimeJoiningDate.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimeTeacherDOB.Text);
                    cmd.Parameters.AddWithValue("@email", txtTEamil.Text);
                    cmd.Parameters.AddWithValue("@mobile", txtTMobile.Text);
                    cmd.Parameters.AddWithValue("@address", txtTAddress.Text);
                    cmd.Parameters.AddWithValue("@image", imagePath);


                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Teacher", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridTacher.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your info");
            }
        }

        private void btnUplaodPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                pictureBoxTeacher.ImageLocation = imageLocation;
            }
        }

        private void dataGridTacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var imagePath = "";

            //File.Copy(imageLocation, Path.Combine(@"C:\Uploads", Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
            //imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());


            txtTeacherName.Text = this.dataGridTacher.CurrentRow.Cells["Name"].Value.ToString();
            txtTFatherName.Text = this.dataGridTacher.CurrentRow.Cells["FatherName"].Value.ToString();
            comboxSubject.Text = this.dataGridTacher.CurrentRow.Cells["Subject"].Value.ToString();
            dateTimeJoiningDate.Text = this.dataGridTacher.CurrentRow.Cells["JoiningDate"].Value.ToString();
            dateTimeTeacherDOB.Text = this.dataGridTacher.CurrentRow.Cells["DOB"].Value.ToString();
            txtTEamil.Text = this.dataGridTacher.CurrentRow.Cells["Email"].Value.ToString();
            txtTMobile.Text = this.dataGridTacher.CurrentRow.Cells["Mobile"].Value.ToString();
            txtTAddress.Text = this.dataGridTacher.CurrentRow.Cells["Address"].Value.ToString();
            //imagePath = this.dataGridTacher.CurrentRow.Cells["Image"].Value.ToString();
            lblTeacherId.Text = this.dataGridTacher.CurrentRow.Cells["TeacherID"].Value.ToString();

            btnAddTacher.Hide();
            btnDeleteTeacher.Show();
            btnUpdateTeacher.Show();
            btnCancel.Show();
            pictureBoxTeacher.Image = null;
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            if (txtTeacherName.Text != "" && txtTMobile.Text != "")
            {
                using (con = new SqlConnection(cs))
                {
                    var imagePath = "";

                    File.Copy(imageLocation, Path.Combine(@"C:\Uploads", Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
                    imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());




                    cmd = new SqlCommand("UPDATE Teacher SET Name=@name,FatherName=@fatherName,Subject=@subject,JoiningDate=@joiningDate,DOB=@dob,Email=@email,Mobile=@mobile,Address=@address,Image=@image WHERE TeacherID = @teacherid", con);
                    cmd.Parameters.AddWithValue("@name", txtTeacherName.Text);
                    cmd.Parameters.AddWithValue("@fatherName", txtTFatherName.Text);
                    cmd.Parameters.AddWithValue("@subject", comboxSubject.Text);
                    cmd.Parameters.AddWithValue("@joiningDate", dateTimeJoiningDate.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimeTeacherDOB.Text);
                    cmd.Parameters.AddWithValue("@email", txtTEamil.Text);
                    cmd.Parameters.AddWithValue("@mobile", txtTMobile.Text);
                    cmd.Parameters.AddWithValue("@address", txtTAddress.Text);
                    cmd.Parameters.AddWithValue("@image", imagePath);
                    cmd.Parameters.AddWithValue("@teacherid", lblTeacherId.Text);

                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Updated Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Teacher", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridTacher.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your info");
            }



            txtTeacherName.Text = "";
            txtTFatherName.Text = "";
            comboxSubject.Text = "";
            dateTimeJoiningDate.Text = "";
            dateTimeTeacherDOB.Text = "";
            txtTEamil.Text = "";
            txtTMobile.Text = "";
            txtTAddress.Text = "";
            pictureBoxTeacher.Image = null;


            //datePicDOB.ResetText();
            //rdBtnFemale.Checked = false;
            //rdBtnMale.Checked = false;

            btnAddTacher.Show();
            btnDeleteTeacher.Hide();
            btnUpdateTeacher.Hide();
             btnCancel.Hide();


        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (lblTeacherId.Text != "")
            {
                using (con = new SqlConnection(cs))
                {
                    cmd = new SqlCommand("DELETE FROM Teacher WHERE TeacherID = @teacherid", con);
                    cmd.Parameters.AddWithValue("@teacherid", lblTeacherId.Text);
                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Delted Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Teacher", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridTacher.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your info");
            }

            //lblSid.Text = "";
            //txtName.Text = "";
            //datePicDOB.ResetText();
            //rdBtnFemale.Checked = false;
            //rdBtnMale.Checked = false;



            txtTeacherName.Text = "";
            txtTFatherName.Text = "";
            comboxSubject.Text = "";
            dateTimeJoiningDate.Text = "";
            dateTimeTeacherDOB.Text = "";
            txtTEamil.Text = "";
            txtTMobile.Text = "";
            txtTAddress.Text = "";
            pictureBoxTeacher.Image = null;

            btnAddTacher.Show();
            btnDeleteTeacher.Hide();
            btnUpdateTeacher.Hide();
            btnCancel.Hide();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTeacherName.Text = "";
            txtTFatherName.Text = "";
            comboxSubject.Text = "";
            dateTimeJoiningDate.Text = "";
            dateTimeTeacherDOB.Text = "";
            txtTEamil.Text = "";
            txtTMobile.Text = "";
            txtTAddress.Text = "";
            pictureBoxTeacher.Image = null;

            btnAddTacher.Show();
            btnDeleteTeacher.Hide();
            btnUpdateTeacher.Hide();
            btnCancel.Hide();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapter = new SqlDataAdapter("select * from Teacher where Name like '" + textBoxSearch.Text + "%'", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridTacher.DataSource = dt;
            con.Close();
        }
    }
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               