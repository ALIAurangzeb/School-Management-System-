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
    public partial class frmClass : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1RU2QB;Initial Catalog=School;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ClassID = 0;

        public frmClass()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            
            frmMainInterface objMain = new frmMainInterface();
            objMain.Show();
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_ClassName.Text != "" && txt_ClassTiming.Text != "" )
            {
                cmd = new SqlCommand("Insert into Class(ClassName,ClassTiming) values(@ClassName,@ClassTiming)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ClassName", txt_ClassName.Text);
                cmd.Parameters.AddWithValue("@ClassTiming", txt_ClassTiming.Text);
               


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

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Class", con);
            adapt.Fill(dt);
            grd_Class.DataSource = dt;
            con.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            txt_ClassName.Text = "";
            txt_ClassTiming.Text = "";

            ClassID = 0;
        }

        private void grd_Class_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClassID = Convert.ToInt32(grd_Class.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_ClassName.Text = grd_Class.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ClassTiming.Text = grd_Class.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_ClassName.Text != "" && txt_ClassTiming.Text != "")
            {
                cmd = new SqlCommand("Update Class Set ClassName=@ClassName,ClassTiming=@ClassTiming Where ClassID=@ClassID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ClassID", ClassID);
                cmd.Parameters.AddWithValue("@ClassName", txt_ClassName.Text);
                cmd.Parameters.AddWithValue("@ClassTiming", txt_ClassTiming.Text);



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
            if (txt_ClassName.Text != "" && txt_ClassTiming.Text != "")
            {
                cmd = new SqlCommand("Delete Class Where ClassID=@ClassID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ClassID", ClassID);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Row By Double Click!");
            }
        }
    }
}
