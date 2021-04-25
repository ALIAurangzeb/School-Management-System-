using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMSS
{
    public partial class LogIn :MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1RU2QB;Initial Catalog=School;Integrated Security=True;");
        SqlDataAdapter adapt;

        public LogIn()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            InitializeComponent();
            for (int i = 0; i <= 1000; i++)
                Thread.Sleep(10);
            t.Abort();
           txtPassword.PasswordChar = '*';
        }

        void Loading()
        {
            SplashScreen frm = new SplashScreen();
            Application.Run(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("Select Count(*) From UserLogIn Where UserName='"+txtUserName.Text+"' and Password='"+txtPassword.Text+"'",con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome You Are Logged In");
                frmMainInterface objMain = new frmMainInterface();
                objMain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Username Or Password");
            }
        }
    }
    }

