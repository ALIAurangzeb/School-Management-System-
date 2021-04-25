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
using Microsoft.VisualBasic;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace SMSS
{
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1RU2QB;Initial Catalog=School;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
       
        public Report()
        {
            InitializeComponent();
            DisplayData();
            showdataClass();
            showdataCourse();
            showdataTeacher();
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
            cmb_Class.DisplayMember = "ClassName";
            cmb_Class.ValueMember = "ClassID";
            cmb_Class.DataSource = dt;
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
            cmb_Course.DisplayMember = "CourseName";
            cmb_Course.ValueMember = "CourseID";
            cmb_Course.DataSource = dt;
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
            cmb_Teacher.DisplayMember = "FirstName";
            cmb_Teacher.ValueMember = "TeacherID";
            cmb_Teacher.DataSource = dt;
            con.Close();
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
            adapt = new SqlDataAdapter("select * from Student", con);
            adapt.Fill(dt);
            grid_StudentRecord.DataSource = dt;
            con.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            if(txt_StudentFirstName.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where FirstName LIKE '"+txt_StudentFirstName.Text+"%'", con);
                adapt.Fill(dt);
                grid_StudentRecord.DataSource = dt;
                con.Close();

            }

            else if (txt_StudentLastName.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where LastName LIKE '" + txt_StudentLastName.Text + "%'", con);
                adapt.Fill(dt);
                grid_StudentRecord.DataSource = dt;
                con.Close();
            }

            else if (txt_StudentFatherName.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where FatherName LIKE '" + txt_StudentFatherName.Text + "%'", con);
                adapt.Fill(dt);
                grid_StudentRecord.DataSource = dt;
                con.Close();
            }

            else if (cmb_Class.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where Class LIKE '" + cmb_Class.Text + "%'", con);
                adapt.Fill(dt);
                grid_StudentRecord.DataSource = dt;
                con.Close();
            }

            else if (cmb_Course.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where Course LIKE '" + cmb_Course.Text + "%'", con);
                adapt.Fill(dt);
                grid_StudentRecord.DataSource = dt;
                con.Close();
            }

            else if (cmb_Teacher.Text.Length > 0)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student Where Teacher LIKE '" + cmb_Teacher.Text + "%'", con);
                adapt.Fill(dt);
                grid_StudentRecord.DataSource = dt;
                con.Close();
            }



        }

        private void txt_StudentFirstName_TextChanged(object sender, EventArgs e)
        {
            txt_StudentLastName.Text = "";
            txt_StudentFatherName.Text = "";
            cmb_Class.Text = "";
            cmb_Course.Text = "";
            cmb_Teacher.Text = "";
        }

        private void txt_StudentLastName_TextChanged(object sender, EventArgs e)
        {
            txt_StudentFirstName.Text = "";
            txt_StudentFatherName.Text = "";
            cmb_Class.Text = "";
            cmb_Course.Text = "";
            cmb_Teacher.Text = "";
        }

        private void txt_StudentFatherName_TextChanged(object sender, EventArgs e)
        {
            txt_StudentLastName.Text = "";
            txt_StudentFirstName.Text = "";
            cmb_Class.Text = "";
            cmb_Course.Text = "";
            cmb_Teacher.Text = "";
        }

        private void cmb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_StudentFirstName.Text = "";
            txt_StudentLastName.Text = "";
            txt_StudentFatherName.Text = "";
            cmb_Course.Text = "";
            cmb_Teacher.Text = "";
        }

        private void cmb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_StudentFirstName.Text = "";
            txt_StudentLastName.Text = "";
            txt_StudentFatherName.Text = "";
            cmb_Class.Text = "";
            cmb_Teacher.Text = "";
        }

        private void cmb_Teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_StudentFirstName.Text = "";
            txt_StudentLastName.Text = "";
            txt_StudentFatherName.Text = "";
            cmb_Course.Text = "";
            cmb_Class.Text = "";
        }

        private void exportgridtopdf(DataGridView dgw,string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 2;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf,5, iTextSharp.text.Font.ITALIC);
            
            //Add Header
            foreach(DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //Add DataRow
             foreach(DataGridViewRow row in dgw.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledailoge = new SaveFileDialog();
            savefiledailoge.FileName = filename;
            savefiledailoge.DefaultExt = ".pdf";

            if (savefiledailoge.ShowDialog() == DialogResult.OK)
            {
                using(FileStream stream = new FileStream(savefiledailoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void pdf_Print_Click(object sender, EventArgs e)
        {
            exportgridtopdf(grid_StudentRecord, "text");
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["sheet1"];
            worksheet.Name = "Student Details";

            for (int  i = 1; i < grid_StudentRecord.Columns.Count+1; i++)
            {
                worksheet.Cells[1, i] = grid_StudentRecord.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < grid_StudentRecord.Rows.Count; i++)
            {
                for (int j =0; j < grid_StudentRecord.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = grid_StudentRecord.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Excel Output";
            saveFileDialoge.DefaultExt = ".xlsx";

            if (saveFileDialoge.ShowDialog()==DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            app.Quit();
        }
    }
}
