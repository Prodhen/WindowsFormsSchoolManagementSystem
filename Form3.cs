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
    public partial class ClassInformation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataRow dr;
        //string gender;
        //string imageLocation = "";

        public ClassInformation()
        {
            InitializeComponent();
            GetTeacherNameFromDatabase();
        }

        private void ClassInformation_Load(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Class", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridClassInformation.DataSource = dt;
            }

        }

        public void GetTeacherNameFromDatabase()
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Teacher", con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Choose Adviser" };
                dt.Rows.InsertAt(dr, 0);

                comboBoxAdviser.ValueMember = "TeacherID";
                comboBoxAdviser.DisplayMember = "Name";

                comboBoxAdviser.DataSource = dt;

                con.Close();
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (txtClassName.Text != "" && txtSeatCapacity.Text != "")
            {
                using (con = new SqlConnection(cs))
                {



                    cmd = new SqlCommand("INSERT INTO Class(Name,SeatCapacity,Section,Adviser,RoomNo)VALUES(@className,@seatCapacity,@section,@adviser,@roomno)", con);
                    cmd.Parameters.AddWithValue("@className", txtClassName.Text);
                    cmd.Parameters.AddWithValue("@seatCapacity", txtSeatCapacity.Text);
                    cmd.Parameters.AddWithValue("@section", comboBoxSection.Text);
                    cmd.Parameters.AddWithValue("@adviser", comboBoxAdviser.Text);
                    cmd.Parameters.AddWithValue("@roomno", txtRoomNo.Text);
                  
                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Class", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridClassInformation.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your info");
            }
            txtClassName.Text = "";
            txtSeatCapacity.Text = "";
            comboBoxSection.Text = "";
            comboBoxAdviser.Text = "";
            txtRoomNo.Text = "";
            lblClassId.Text = "";

            //btnAddClass.Hide();
            //btnDelete.Show();
            //btnUpdate.Show();
            //btnCancel.Hide();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (txtClassName.Text != "")
            {
                using (con = new SqlConnection(cs))
                {
                    cmd = new SqlCommand("UPDATE Class SET Name=@className,SeatCapacity=@seatCapacity,Section=@section,Adviser=@adviser,RoomNo=@roomno WHERE ClassId=@classId", con);
                    cmd.Parameters.AddWithValue("@className", txtClassName.Text);
                    cmd.Parameters.AddWithValue("@seatCapacity", txtSeatCapacity.Text);
                    cmd.Parameters.AddWithValue("@section", comboBoxSection.Text);
                    cmd.Parameters.AddWithValue("@adviser", comboBoxAdviser.Text);
                    cmd.Parameters.AddWithValue("@roomno", txtRoomNo.Text);
                    cmd.Parameters.AddWithValue("@classId", lblClassId.Text);

                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Updated Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Class", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridClassInformation.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your info");
            }
            txtClassName.Text = "";
            txtSeatCapacity.Text = "";
            comboBoxSection.Text = "";
            comboBoxAdviser.Text = "";
            txtRoomNo.Text = "";
            lblClassId.Text = "";

            btnAddClass.Show();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnCancel.Hide();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblClassId.Text!="")
            {
                using (con = new SqlConnection(cs))
                {
                    cmd = new SqlCommand("DELETE FROM Class WHERE ClassId = @classId", con);
                    cmd.Parameters.AddWithValue("@classId", lblClassId.Text);
                    con.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Data Delted Successfully");
                        adapter = new SqlDataAdapter("SELECT * FROM Class", con);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridClassInformation.DataSource = dt;
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


              txtClassName.Text = "";
             txtSeatCapacity.Text = "";
             comboBoxSection.Text = "";
             comboBoxAdviser.Text = "";
             txtRoomNo.Text = "";
             lblClassId.Text = "";

            btnAddClass.Show();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnCancel.Hide();




        }

        private void dataGridClassInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClassName.Text = this.dataGridClassInformation.CurrentRow.Cells["Name"].Value.ToString();
            txtSeatCapacity.Text = this.dataGridClassInformation.CurrentRow.Cells["SeatCapacity"].Value.ToString();
            comboBoxSection.Text = this.dataGridClassInformation.CurrentRow.Cells["Section"].Value.ToString();
            comboBoxAdviser.Text = this.dataGridClassInformation.CurrentRow.Cells["Adviser"].Value.ToString();
            txtRoomNo.Text = this.dataGridClassInformation.CurrentRow.Cells["RoomNo"].Value.ToString();
            lblClassId.Text = this.dataGridClassInformation.CurrentRow.Cells["ClassId"].Value.ToString();


            btnAddClass.Hide();
            btnDelete.Show();
            btnUpdate.Show();
            btnCancel.Show();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtClassName.Text = "";
            txtSeatCapacity.Text = "";
            comboBoxSection.Text = "";
            comboBoxAdviser.Text = "";
            txtRoomNo.Text = "";
            lblClassId.Text = "";

            btnAddClass.Show();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnCancel.Hide();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapter = new SqlDataAdapter("select * from Class where Name like '" + textBoxSearch.Text + "%'", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridClassInformation.DataSource = dt;
            con.Close();
        }
    }
}
