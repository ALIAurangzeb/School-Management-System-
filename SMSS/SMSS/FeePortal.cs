using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic;

namespace SMSS
{
    public partial class FeePortal : MetroFramework.Forms.MetroForm
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1RU2QB;Initial Catalog=School;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int StudentID = 0;
        string imgLoc = "";

        public FeePortal()
        {
            InitializeComponent();
            DisplayData();
            showdataClass();
            showdataCourse();
            showdataTeacher();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Student", con);
            adapt.Fill(dt);
            grid_Fee.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            txt_StudentFirstName.Text = "";
            txt_StudentLastName.Text = "";
            cmb_CourseFee.Text = "";
            txt_FeePaid.Text = "";
            txt_Balance.Text = "";
            txt_AddFee.Text = "";
            img_Box.Image = null;

            StudentID = 0;
        }

        public void showdataClass()
        {
            con.Open();
            cmd = new SqlCommand("Select ClassID,ClassName from Class", con);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();

            DataRow Filaa = dt.NewRow();
            Filaa["ClassName"] = "";
            cmb_SearchClass.DisplayMember = "ClassName";
            cmb_SearchClass.ValueMember = "ClassID";
            cmb_SearchClass.DataSource = dt;
            con.Close();
        }

        public void showdataCourse()
        {
            con.Open();
            cmd = new SqlCommand("Select CourseID,CourseName from Course", con);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();

            DataRow Filaa = dt.NewRow();
            Filaa["CourseName"] = "";
            cmb_SearchCourse.DisplayMember = "CourseName";
            cmb_SearchCourse.ValueMember = "CourseID";
            cmb_SearchCourse.DataSource = dt;
            con.Close();
        }

        public void showdataTeacher()
        {
            con.Open();
            cmd = new SqlCommand("Select TeacherID,FirstName from Teacher", con);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();

            DataRow Filaa = dt.NewRow();
            Filaa["FirstName"] = "";
            cmb_SearchTeacher.DisplayMember = "FirstName";
            cmb_SearchTeacher.ValueMember = "TeacherID";
            cmb_SearchTeacher.DataSource = dt;
            con.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtSearchLastName.Text = "";
            cmb_SearchClass.Text = "";
            cmb_SearchCourse.Text = "";
            cmb_SearchTeacher.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtSearchFirstName.Text = "";
            cmb_SearchClass.Text = "";
            cmb_SearchCourse.Text = "";
            cmb_SearchTeacher.Text = "";
        }

        private void cmb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchFirstName.Text = "";
            txtSearchLastName.Text = "";
            cmb_SearchClass.Text = "";
            cmb_SearchCourse.Text = "";
            cmb_SearchTeacher.Text = "";
        }

        private void cmb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchFirstName.Text = "";
            txtSearchLastName.Text = "";
            cmb_SearchClass.Text = "";
            cmb_SearchTeacher.Text = "";
        }

        private void cmb_Teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchFirstName.Text = "";
            txtSearchLastName.Text = "";
            cmb_SearchCourse.Text = "";
            cmb_SearchClass.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmMainInterface objMain = new frmMainInterface();
            objMain.Show();
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtSearchFirstName.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where FirstName LIKE '" + txtSearchFirstName.Text + "%'", con);
                adapt.Fill(dt);
                grid_Fee.DataSource = dt;
                con.Close();

            }

            else if (txtSearchLastName.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where LastName LIKE '" + txtSearchLastName.Text + "%'", con);
                adapt.Fill(dt);
                grid_Fee.DataSource = dt;
                con.Close();
            }


            else if (cmb_SearchClass.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where Class LIKE '" + cmb_SearchClass.Text + "%'", con);
                adapt.Fill(dt);
                grid_Fee.DataSource = dt;
                con.Close();
            }

            else if (cmb_SearchCourse.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where Course LIKE '" + cmb_SearchCourse.Text + "%'", con);
                adapt.Fill(dt);
                grid_Fee.DataSource = dt;
                con.Close();
            }

            else if (cmb_SearchTeacher.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where Teacher LIKE '" + cmb_SearchTeacher.Text + "%'", con);
                adapt.Fill(dt);
                grid_Fee.DataSource = dt;
                con.Close();
            }
        }

        private void grid_Fee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentID = Convert.ToInt32(grid_Fee.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_StudentFirstName.Text = grid_Fee.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_StudentLastName.Text = grid_Fee.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_CourseFee.Text = grid_Fee.Rows[e.RowIndex].Cells[13].Value.ToString();
            txt_FeePaid.Text = grid_Fee.Rows[e.RowIndex].Cells[14].Value.ToString();
            txt_Balance.Text = grid_Fee.Rows[e.RowIndex].Cells[15].Value.ToString();

            MemoryStream ms = new MemoryStream((byte[])grid_Fee.CurrentRow.Cells[17].Value);
            img_Box.Image = Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_AddFee.Text != "" && txt_FeePaid.Text != "")
            {

                txt_FeePaid.Text = Convert.ToString(Convert.ToInt32(txt_FeePaid.Text) + Convert.ToInt32(txt_AddFee.Text));
                txt_Balance.Text = Convert.ToString(Convert.ToInt32(cmb_CourseFee.Text) - Convert.ToInt32(txt_FeePaid.Text));

                cmd = new SqlCommand("Update Student Set TotalFee=@TotalFee,FeePaid=@FeePaid,Balance=@Balance Where StudentID=@StudentID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@StudentID", StudentID);
                cmd.Parameters.AddWithValue("@TotalFee", cmb_CourseFee.Text);
                cmd.Parameters.AddWithValue("@FeePaid", txt_FeePaid.Text);
                cmd.Parameters.AddWithValue("@Balance", txt_Balance.Text);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                ClearData();
                DisplayData();
            }

            else
            {
                MessageBox.Show("Insert Fee Or Select Row By Double Click");
            }

        }

        private void txt_FeePaid_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_AddFee_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_AddFee.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Number Only");
                txt_AddFee.Text = txt_AddFee.Text.Remove(txt_AddFee.Text.Length - 1);
            }
        }
    }


        
    }
