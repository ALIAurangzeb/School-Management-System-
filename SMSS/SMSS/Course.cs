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

namespace SMSS
{
    public partial class frmCourse : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1RU2QB;Initial Catalog=School;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int CourseID = 0;

        public frmCourse()
        {
            InitializeComponent();
            showdataClass();
            DisplayData();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            
            frmMainInterface objMain = new frmMainInterface();
            objMain.Show();
            this.Close();

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
            Filaa["ClassName"] = "Select Class";
            cmb_ClassName.DisplayMember = "ClassName";
            cmb_ClassName.ValueMember = "ClassID";
            cmb_ClassName.DataSource = dt;
            con.Close();
        }

        public void showdataClassID(string ClassID)
        {
            con.Open();
            cmd = new SqlCommand("Select ClassID,ClassName from Class Where ClassID=@ClassID", con);
            cmd.Parameters.AddWithValue("ClassID", ClassID);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();

            DataRow Filaa = dt.NewRow();
            Filaa["ClassName"] = "Select Class";
            cmb_ClassID.DisplayMember = "ClassID";
            cmb_ClassID.ValueMember = "ClassID";
            cmb_ClassID.DataSource = dt;
            con.Close();
        }

        private void cmb_ClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ClassName.SelectedValue.ToString() != null)
            {
                String ClassID = cmb_ClassName.SelectedValue.ToString();
                showdataClassID(ClassID);
            }
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Course", con);
            adapt.Fill(dt);
            grid_Course.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            txt_CourseName.Text = "";
            date_CourseStart.Text = "";
            date_CourseEnd.Text = "";
            txt_CourseTiming.Text = "";
            cmb_ClassName.Text = "";
            cmb_ClassID.Text = "";
            txt_CourseFee.Text = "";

           CourseID = 0;
        }

        private void grid_Course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CourseID = Convert.ToInt32(grid_Course.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_CourseName.Text = grid_Course.Rows[e.RowIndex].Cells[1].Value.ToString();
            date_CourseStart.Text = grid_Course.Rows[e.RowIndex].Cells[2].Value.ToString();
            date_CourseEnd.Text = grid_Course.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_CourseTiming.Text = grid_Course.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmb_ClassName.Text = grid_Course.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmb_ClassID.Text = grid_Course.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_CourseFee.Text = grid_Course.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_CourseName.Text != "" && cmb_ClassID.Text != "")
            {
                cmd = new SqlCommand("Insert into Course(CourseName,CourseStart,CourseEnd,CourseTiming,ClassName,ClassID,CourseFee) values(@CourseName,@CourseStart,@CourseEnd,@CourseTiming,@ClassName,@ClassID,@CourseFee)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@CourseName", txt_CourseName.Text);
                cmd.Parameters.AddWithValue("@CourseStart", date_CourseStart.Text);
                cmd.Parameters.AddWithValue("@CourseEnd", date_CourseEnd.Text);
                cmd.Parameters.AddWithValue("@ClassName", cmb_ClassName.Text);
                cmd.Parameters.AddWithValue("@CourseTiming", txt_CourseTiming.Text);
                cmd.Parameters.AddWithValue("@ClassID", cmb_ClassID.Text);
                cmd.Parameters.AddWithValue("@CourseFee", txt_CourseFee.Text);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_CourseName.Text != "" && cmb_ClassID.Text != "")
            {
                cmd = new SqlCommand("Update Course Set CourseName=@CourseName,CourseStart=@CourseStart,CourseEnd=@CourseEnd,ClassName=@ClassName,ClassID=@ClassID,CourseFee=@CourseFee Where CourseID=@CourseID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@CourseID", CourseID);
                cmd.Parameters.AddWithValue("@CourseName", txt_CourseName.Text);
                cmd.Parameters.AddWithValue("@CourseStart", date_CourseStart.Text);
                cmd.Parameters.AddWithValue("@CourseEnd", date_CourseEnd.Text);
                cmd.Parameters.AddWithValue("@ClassName", cmb_ClassName.Text);
                cmd.Parameters.AddWithValue("@CourseTiming", txt_CourseTiming.Text);
                cmd.Parameters.AddWithValue("@ClassID", cmb_ClassID.Text);
                cmd.Parameters.AddWithValue("@CourseFee", txt_CourseFee.Text);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_CourseName.Text != "" && cmb_ClassID.Text != "")
            {

                cmd = new SqlCommand("Delete Course Where CourseID=@CourseID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@CourseID", CourseID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Delete Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Row By Double Clik!");
            }
        }

        private void txt_CourseFee_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_CourseFee.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Number Only");
                txt_CourseFee.Text = txt_CourseFee.Text.Remove(txt_CourseFee.Text.Length - 1);
            }
        }
    }


    }

    
    
