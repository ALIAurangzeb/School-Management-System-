using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSS
{
    public partial class frmMainInterface : MetroFramework.Forms.MetroForm
    {
        public frmMainInterface()
        {
            InitializeComponent();
        }

        private void btn_StudentRegistration_Click(object sender, EventArgs e)
        {
           
            frmStudent objStudent = new frmStudent();
            objStudent.Show();
            this.Close();
        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
           
            frmClass objClass = new frmClass();
            objClass.Show();
            this.Close();
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            
            frmCourse objCourse = new frmCourse();
            objCourse.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmMainInterface_Load(object sender, EventArgs e)
        {

        }

        private void btn_UserRegistration_Click(object sender, EventArgs e)
        {
            frmUserPortal objStudent = new frmUserPortal();
            objStudent.Show();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn objLogOut = new LogIn();
            objLogOut.Show();
            
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Report objStudent = new Report();
            objStudent.Show();
            this.Close();
        }

        private void btn_FeeForm_Click(object sender, EventArgs e)
        {
            FeePortal objFeePortal = new FeePortal();
            objFeePortal.Show();
            this.Close();
        }

        private void btn_TeacherRegistraion_Click(object sender, EventArgs e)
        {
            
           frmTeacher objTeacher = new frmTeacher();
            objTeacher.Show();
            this.Close();
        }
    }
}
