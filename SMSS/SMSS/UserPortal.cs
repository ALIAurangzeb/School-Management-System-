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
    public partial class frmUserPortal : MetroFramework.Forms.MetroForm
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1RU2QB;Initial Catalog=School;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int UserID = 0;


        public frmUserPortal()
        {
            InitializeComponent();
            DisplayData();
        }

        private void grid_Teacher_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UserID = Convert.ToInt32(grid_User.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_UserName.Text = grid_User.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Password.Text = grid_User.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void ClearData()
        {
            txt_UserName.Text = "";
            txt_Password.Text = "";
           
            UserID = 0;
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from UserLogIn", con);
            adapt.Fill(dt);
            grid_User.DataSource = dt;
            con.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text != "" && txt_Password.Text != "")
            {

            cmd = new SqlCommand("Insert into UserLogIn(UserName,Password) Values(@UserName,@Password)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@UserName", txt_UserName.Text);
            cmd.Parameters.AddWithValue("@Password", txt_Password.Text);

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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frmMainInterface objMain = new frmMainInterface();
            objMain.Show();
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text != "" && txt_Password.Text != "")
            {

                cmd = new SqlCommand("Update UserLogIn Set UserName=@UserName, Password=@Password Where UserID=@UserID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@UserName", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@Password", txt_Password.Text);

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
            if (txt_UserName.Text != "" && txt_Password.Text != "")
            {

                cmd = new SqlCommand("Delete UserLogIn Where UserID=@UserID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@UserID", UserID);
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

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("TRUNCATE TABLE Class;TRUNCATE TABLE Course;TRUNCATE TABLE Teacher;TRUNCATE TABLE Student;", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Reset Successfully");
        }

        
    }
}
