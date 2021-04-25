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
    public partial class frmStudent : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1RU2QB;Initial Catalog=School;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int StudentID = 0;
        string imgLoc = "";

        public frmStudent()
        {
            InitializeComponent();
            showdataClass();
            DisplayData();
            showdataGender();


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
            cmb_Class.DisplayMember = "ClassName";
            cmb_Class.ValueMember = "ClassID";
            cmb_Class.DataSource = dt;
            con.Close();
        }

        public void showdataCourse(string ClassID)
        {
            con.Open();
            cmd = new SqlCommand("Select CourseID,CourseName from Course Where ClassID= @ClassID", con);
            cmd.Parameters.AddWithValue("ClassID", ClassID);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            adapt.Fill(dt2);
            con.Close();

            DataRow dr2 = dt2.NewRow();
            dr2["CourseName"] = "Select Course";
            dt2.Rows.InsertAt(dr2, 0);

            cmb_Course.DisplayMember = "CourseName";
            cmb_Course.ValueMember = "CourseID";
            cmb_Course.DataSource = dt2;
            con.Close();

        }

        public void showdataTeacher(string CourseID)
        {
            con.Open();
            cmd = new SqlCommand("Select TeacherID,FirstName from Teacher Where CourseID= @CourseID", con);
            cmd.Parameters.AddWithValue("CourseID", CourseID);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            adapt.Fill(dt2);
            con.Close();

            DataRow dr2 = dt2.NewRow();
            dr2["FirstName"] = "Select Teacher";
            dt2.Rows.InsertAt(dr2, 0);

            cmb_Teacher.DisplayMember = "FirstName";
            cmb_Teacher.ValueMember = "TeacherID";
            cmb_Teacher.DataSource = dt2;
            con.Close();

        }

        public void showdataCourseFee(string CourseID)
        {
            con.Open();
            cmd = new SqlCommand("Select CourseID,CourseFee from Course Where CourseID= @CourseID", con);
            cmd.Parameters.AddWithValue("CourseID", CourseID);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            adapt.Fill(dt2);
            con.Close();

            DataRow dr2 = dt2.NewRow();
            
            cmb_CourseFee.DisplayMember = "CourseFee";
            cmb_CourseFee.ValueMember = "CourseID";
            cmb_CourseFee.DataSource = dt2;
            con.Close();

        }

        private void cmb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_Class.SelectedValue.ToString() != null)
            {
                String ClassID = cmb_Class.SelectedValue.ToString();
                showdataCourse(ClassID);
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_StudentFirstName.Text != "" && txt_StudentMobileNo.Text != "" && cmb_Teacher.Text != "" && img_Box.Image != null)
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                cmd = new SqlCommand("Insert into Student(FirstName,LastName,FatherName,FatherID,DOB,DOR,Class,Course,Gender,Teacher,Address,EmailID,MobileNo,TotalFee,FeePaid,Balance,Image) values(@FirstName,@LastName,@FatherName,@FatherID,@DOB,@DOR,@Class,@Course,@Gender,@Teacher,@Address,@EmailID,@MobileNo,@TotalFee,@FeePaid,@Balance,@Img)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@FirstName", txt_StudentFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_StudentLastName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txt_StudentFatherName.Text);
                cmd.Parameters.AddWithValue("@FatherID", txt_StudentFatherID.Text);
                cmd.Parameters.AddWithValue("@DOB", Student_DOB.Text);
                cmd.Parameters.AddWithValue("@DOR", Student_DOR.Text);
                cmd.Parameters.AddWithValue("@Class", cmb_Class.Text);
                cmd.Parameters.AddWithValue("@Course", cmb_Course.Text);
                cmd.Parameters.AddWithValue("@Gender", cmb_Gender.Text);
                cmd.Parameters.AddWithValue("@Teacher", cmb_Teacher.Text);
                cmd.Parameters.AddWithValue("@Address", txt_StudentAddress.Text);
                cmd.Parameters.AddWithValue("@EmailID", txt_StudentEmailID.Text);
                cmd.Parameters.AddWithValue("@MobileNo", txt_StudentMobileNo.Text);
                cmd.Parameters.AddWithValue("@TotalFee", cmb_CourseFee.Text);
                cmd.Parameters.AddWithValue("@FeePaid", txt_FeePaid.Text);
                cmd.Parameters.AddWithValue("@Balance", txt_Balance.Text);
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
        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Student", con);
            adapt.Fill(dt);
            grid_Student.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            txt_StudentFirstName.Text = "";
            txt_StudentLastName.Text = "";
            txt_StudentFatherName.Text = "";
            txt_StudentFatherID.Text = "";
            Student_DOB.Text = "";
            Student_DOR.Text = "";
            cmb_Class.Text = "";
            cmb_Course.Text = "";
            cmb_Teacher.Text = "";
            cmb_Gender.Text = "";
            txt_StudentAddress.Text = "";
            txt_StudentEmailID.Text = "";
            txt_StudentMobileNo.Text = "";
            cmb_CourseFee.Text = "";
            txt_FeePaid.Text = "";
            txt_Balance.Text = "";
            img_Box.Image = null;

            StudentID = 0;
        }

        public void showdataGender()
        {
            con.Open();
            cmd = new SqlCommand("Select GenderID,GenderType from Gender", con);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt3 = new DataTable();
            adapt.Fill(dt3);
            con.Close();

            DataRow Fila3 = dt3.NewRow();
            Fila3["GenderType"] = "Select Gender";
            cmb_Gender.DisplayMember = "GenderType";
            cmb_Gender.ValueMember = "GenderID";
            cmb_Gender.DataSource = dt3;
            con.Close();
        }


        private void grid_Student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentID = Convert.ToInt32(grid_Student.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_StudentFirstName.Text = grid_Student.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_StudentLastName.Text = grid_Student.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_StudentFatherName.Text = grid_Student.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_StudentFatherID.Text = grid_Student.Rows[e.RowIndex].Cells[4].Value.ToString();
            Student_DOB.Text = grid_Student.Rows[e.RowIndex].Cells[5].Value.ToString();
            Student_DOR.Text = grid_Student.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_StudentEmailID.Text = grid_Student.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_StudentMobileNo.Text = grid_Student.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmb_Gender.Text = grid_Student.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmb_Class.Text = grid_Student.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmb_Course.Text = grid_Student.Rows[e.RowIndex].Cells[11].Value.ToString();
            cmb_Teacher.Text = grid_Student.Rows[e.RowIndex].Cells[12].Value.ToString();
            cmb_CourseFee.Text = grid_Student.Rows[e.RowIndex].Cells[13].Value.ToString();
            txt_FeePaid.Text = grid_Student.Rows[e.RowIndex].Cells[14].Value.ToString();
            txt_Balance.Text = grid_Student.Rows[e.RowIndex].Cells[15].Value.ToString();
            txt_StudentAddress.Text = grid_Student.Rows[e.RowIndex].Cells[16].Value.ToString();
            //Retriver img_Box
            MemoryStream ms = new MemoryStream((byte[])grid_Student.CurrentRow.Cells[17].Value);
           img_Box.Image = Image.FromStream(ms);


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_StudentFirstName.Text != "" && txt_StudentMobileNo.Text != "" && cmb_Teacher.Text != "" && img_Box.Image != null)
            {
                if (imgLoc == "")
                {

                }
                else
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);


                    cmd = new SqlCommand("Update Student Set Image=@Img  Where StudentID=@StudentID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    cmd.Parameters.AddWithValue("@Img", img);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                cmd = new SqlCommand("Update Student Set FirstName=@FirstName,LastName=@LastName,FatherName=@FatherName,FatherID=@FatherID,DOB=@DOB,DOR=@DOR,Class=@Class,Course=@Course,Gender=@Gender,Teacher=@Teacher,Address=@Address,EmailID=@EmailID,MobileNo=@MobileNo,TotalFee=@TotalFee,FeePaid=@FeePaid,Balance=@Balance Where StudentID=@StudentID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@StudentID", StudentID);
                cmd.Parameters.AddWithValue("@FirstName", txt_StudentFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_StudentLastName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txt_StudentFatherName.Text);
                cmd.Parameters.AddWithValue("@FatherID", txt_StudentFatherID.Text);
                cmd.Parameters.AddWithValue("@DOB", Student_DOB.Text);
                cmd.Parameters.AddWithValue("@DOR", Student_DOR.Text);
                cmd.Parameters.AddWithValue("@Class", cmb_Class.Text);
                cmd.Parameters.AddWithValue("@Course", cmb_Course.Text);
                cmd.Parameters.AddWithValue("@Gender", cmb_Gender.Text);
                cmd.Parameters.AddWithValue("@Teacher", cmb_Teacher.Text);
                cmd.Parameters.AddWithValue("@Address", txt_StudentAddress.Text);
                cmd.Parameters.AddWithValue("@EmailID", txt_StudentEmailID.Text);
                cmd.Parameters.AddWithValue("@MobileNo", txt_StudentMobileNo.Text);
                cmd.Parameters.AddWithValue("@TotalFee", cmb_CourseFee.Text);
                cmd.Parameters.AddWithValue("@FeePaid", txt_FeePaid.Text);
                cmd.Parameters.AddWithValue("@Balance", txt_Balance.Text);
                


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
            if (txt_StudentFirstName.Text != "" && txt_StudentMobileNo.Text != "")
            { 

                cmd = new SqlCommand("Delete Student Where StudentID=@StudentID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@StudentID", StudentID);
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

        private void cmb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Course.SelectedValue.ToString() != null)
            {
                String CourseID = cmb_Course.SelectedValue.ToString();
                showdataTeacher(CourseID);
                showdataCourseFee(CourseID);
            }
        }

        private void imb_Box_DoubleClick(object sender, EventArgs e)
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

        private void txt_FeePaid_TextChanged(object sender, EventArgs e)
        {
           

            if ((!string.IsNullOrEmpty(cmb_CourseFee.Text)) && (!string.IsNullOrEmpty(txt_FeePaid.Text))) {

                if (System.Text.RegularExpressions.Regex.IsMatch(txt_FeePaid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please Enter Number Only");
                    txt_FeePaid.Text = txt_FeePaid.Text.Remove(txt_FeePaid.Text.Length - 1);
                }

                else { 

                txt_Balance.Text = Convert.ToString(Convert.ToInt32(cmb_CourseFee.Text) - Convert.ToInt32(txt_FeePaid.Text));

                }
            }
        }

        private void txt_StudentFatherID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_StudentFatherID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Number Only");
                txt_StudentFatherID.Text = txt_StudentFatherID.Text.Remove(txt_StudentFatherID.Text.Length - 1);
            }
        }

        private void txt_StudentMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_StudentMobileNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Number Only");
                txt_StudentMobileNo.Text = txt_StudentMobileNo.Text.Remove(txt_StudentMobileNo.Text.Length - 1);
            }
        }

        private void cmb_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Balance_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

