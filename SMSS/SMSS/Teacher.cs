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
    public partial class frmTeacher : MetroFramework.Forms.MetroForm
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1RU2QB;Initial Catalog=School;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int TeacherID = 0;
        string imgLoc = "";

        public frmTeacher()
        {
            InitializeComponent();
            DisplayData();
            showdataCourse();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

            frmMainInterface objMain = new frmMainInterface();
            objMain.Show();
            this.Close();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Teacher", con);
            adapt.Fill(dt);
            grid_Teacher.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            txt_TeacherFirstName.Text = "";
            txt_TeacherLastName.Text = "";
            txt_TeacherCNIC.Text = "";
            txt_TeacherMobileNo.Text = "";
            cmb_CourseName.Text = "";
            cmb_CourseID.Text = "";
            txt_TeacherSalary.Text = "";
            txt_TeacherAddress.Text = "";
            img_Box.Image = null;

            TeacherID = 0;
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
            Filaa["CourseName"] = "Select Course";
            cmb_CourseName.DisplayMember = "CourseName";
            cmb_CourseName.ValueMember = "CourseID";
            cmb_CourseName.DataSource = dt;
            con.Close();
        }

        public void showdataCourseID(string CourseID)
        {
            con.Open();
            cmd = new SqlCommand("Select CourseID,CourseName from Course Where CourseID=@CourseID", con);
            cmd.Parameters.AddWithValue("CourseID", CourseID);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();

            DataRow Filaa = dt.NewRow();
            Filaa["CourseName"] = "Select Class";
            cmb_CourseID.DisplayMember = "CourseID";
            cmb_CourseID.ValueMember = "CourseID";
            cmb_CourseID.DataSource = dt;
            con.Close();
        }

        private void cmb_CourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_CourseName.SelectedValue.ToString() != null)
            {
                String CourseID = cmb_CourseName.SelectedValue.ToString();
                showdataCourseID(CourseID);
            }
        }

        private void grid_Teacher_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TeacherID = Convert.ToInt32(grid_Teacher.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_TeacherFirstName.Text = grid_Teacher.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_TeacherLastName.Text = grid_Teacher.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_TeacherCNIC.Text = grid_Teacher.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmb_CourseName.Text = grid_Teacher.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_TeacherAddress.Text = grid_Teacher.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_TeacherMobileNo.Text = grid_Teacher.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_TeacherSalary.Text = grid_Teacher.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmb_CourseID.Text = grid_Teacher.Rows[e.RowIndex].Cells[8].Value.ToString();
            //Retriver img_Box
            MemoryStream ms = new MemoryStream((byte[])grid_Teacher.CurrentRow.Cells[9].Value);
            img_Box.Image = Image.FromStream(ms);

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_TeacherFirstName.Text != "" && txt_TeacherCNIC.Text != "" && img_Box.Image != null)
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);



                cmd = new SqlCommand("Insert into Teacher(FirstName,LastName,CNIC,CourseName,Address,MobileNo,Salary,CourseID,Image) Values(@FirstName,@LastName,@CNIC,@CourseName,@Address,@MobileNo,@Salary,@CourseID,@Img)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@FirstName", txt_TeacherFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_TeacherLastName.Text);
                cmd.Parameters.AddWithValue("@CNIC", txt_TeacherCNIC.Text);
                cmd.Parameters.AddWithValue("@CourseName", cmb_CourseName.Text);
                cmd.Parameters.AddWithValue("@Address", txt_TeacherAddress.Text);
                cmd.Parameters.AddWithValue("@MobileNo", txt_TeacherMobileNo.Text);
                cmd.Parameters.AddWithValue("@Salary", txt_TeacherSalary.Text);
                cmd.Parameters.AddWithValue("@CourseID", cmb_CourseID.Text);
                cmd.Parameters.AddWithValue("@Img", img);
                


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Complete Details With Image !");
            }
        }

        private void img_Box_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*gif)|*.gif|All Files (*.*)|*.*";
            dlg.Title = "Select Image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                img_Box.ImageLocation = imgLoc;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_TeacherFirstName.Text != "" && txt_TeacherCNIC.Text != "")
            {
                if (imgLoc == "")
                {
                   
                }
                else {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);


                    cmd = new SqlCommand("Update Teacher Set Image=@Img  Where TeacherID=@TeacherID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                    cmd.Parameters.AddWithValue("@Img", img);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

               
                cmd = new SqlCommand("Update Teacher Set FirstName=@FirstName,LastName=@LastName,CNIC=@CNIC,CourseName=@CourseName,Address=@Address,MobileNo=@MobileNo,Salary=@Salary,CourseID=@CourseID Where TeacherID=@TeacherID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                cmd.Parameters.AddWithValue("@FirstName", txt_TeacherFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_TeacherLastName.Text);
                cmd.Parameters.AddWithValue("@CNIC", txt_TeacherCNIC.Text);
                cmd.Parameters.AddWithValue("@CourseName", cmb_CourseName.Text);
                cmd.Parameters.AddWithValue("@Address", txt_TeacherAddress.Text);
                cmd.Parameters.AddWithValue("@MobileNo", txt_TeacherMobileNo.Text);
                cmd.Parameters.AddWithValue("@Salary", txt_TeacherSalary.Text);
                cmd.Parameters.AddWithValue("@CourseID", cmb_CourseID.Text);

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
            if (txt_TeacherFirstName.Text != "" && txt_TeacherCNIC.Text != "" && img_Box.Image != null)
            {

                cmd = new SqlCommand("Delete Teacher Where TeacherID=@TeacherID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
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

        private void txt_TeacherCNIC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_TeacherCNIC.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Number Only");
                txt_TeacherCNIC.Text = txt_TeacherCNIC.Text.Remove(txt_TeacherCNIC.Text.Length - 1);
            }
        }

        private void txt_TeacherMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_TeacherMobileNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Number Only");
                txt_TeacherMobileNo.Text = txt_TeacherMobileNo.Text.Remove(txt_TeacherMobileNo.Text.Length - 1);
            }
        }

        private void txt_TeacherSalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_TeacherSalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Number Only");
                txt_TeacherSalary.Text = txt_TeacherSalary.Text.Remove(txt_TeacherSalary.Text.Length - 1);
            }
        }
    }
}
