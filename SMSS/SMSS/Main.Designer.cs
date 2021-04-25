namespace SMSS
{
    partial class frmMainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Course = new System.Windows.Forms.Button();
            this.btn_Class = new System.Windows.Forms.Button();
            this.btn_UserRegistration = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_FeeForm = new System.Windows.Forms.Button();
            this.btn_TeacherRegistraion = new System.Windows.Forms.Button();
            this.btn_StudentRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::SMSS.Properties.Resources.Quit;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(314, 465);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(138, 132);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackgroundImage = global::SMSS.Properties.Resources.LogOut;
            this.btn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Location = new System.Drawing.Point(500, 429);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(125, 132);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Course
            // 
            this.btn_Course.BackColor = System.Drawing.Color.White;
            this.btn_Course.BackgroundImage = global::SMSS.Properties.Resources.Course;
            this.btn_Course.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Course.Location = new System.Drawing.Point(480, 106);
            this.btn_Course.Name = "btn_Course";
            this.btn_Course.Size = new System.Drawing.Size(149, 132);
            this.btn_Course.TabIndex = 2;
            this.btn_Course.UseVisualStyleBackColor = false;
            this.btn_Course.Click += new System.EventHandler(this.btn_Course_Click);
            // 
            // btn_Class
            // 
            this.btn_Class.BackColor = System.Drawing.Color.White;
            this.btn_Class.BackgroundImage = global::SMSS.Properties.Resources.Class;
            this.btn_Class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Class.Location = new System.Drawing.Point(133, 106);
            this.btn_Class.Name = "btn_Class";
            this.btn_Class.Size = new System.Drawing.Size(132, 132);
            this.btn_Class.TabIndex = 8;
            this.btn_Class.UseVisualStyleBackColor = false;
            this.btn_Class.Click += new System.EventHandler(this.btn_Class_Click);
            // 
            // btn_UserRegistration
            // 
            this.btn_UserRegistration.BackgroundImage = global::SMSS.Properties.Resources.Users;
            this.btn_UserRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UserRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserRegistration.Location = new System.Drawing.Point(314, 267);
            this.btn_UserRegistration.Name = "btn_UserRegistration";
            this.btn_UserRegistration.Size = new System.Drawing.Size(123, 132);
            this.btn_UserRegistration.TabIndex = 9;
            this.btn_UserRegistration.UseVisualStyleBackColor = true;
            this.btn_UserRegistration.Click += new System.EventHandler(this.btn_UserRegistration_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BackgroundImage = global::SMSS.Properties.Resources.Reports;
            this.btn_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Location = new System.Drawing.Point(133, 429);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(134, 139);
            this.btn_Report.TabIndex = 6;
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_FeeForm
            // 
            this.btn_FeeForm.BackColor = System.Drawing.Color.White;
            this.btn_FeeForm.BackgroundImage = global::SMSS.Properties.Resources.Fee;
            this.btn_FeeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FeeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FeeForm.Location = new System.Drawing.Point(73, 267);
            this.btn_FeeForm.Name = "btn_FeeForm";
            this.btn_FeeForm.Size = new System.Drawing.Size(139, 132);
            this.btn_FeeForm.TabIndex = 7;
            this.btn_FeeForm.UseVisualStyleBackColor = false;
            this.btn_FeeForm.Click += new System.EventHandler(this.btn_FeeForm_Click);
            // 
            // btn_TeacherRegistraion
            // 
            this.btn_TeacherRegistraion.BackColor = System.Drawing.Color.White;
            this.btn_TeacherRegistraion.BackgroundImage = global::SMSS.Properties.Resources.Teacher;
            this.btn_TeacherRegistraion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TeacherRegistraion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TeacherRegistraion.Location = new System.Drawing.Point(558, 267);
            this.btn_TeacherRegistraion.Name = "btn_TeacherRegistraion";
            this.btn_TeacherRegistraion.Size = new System.Drawing.Size(137, 132);
            this.btn_TeacherRegistraion.TabIndex = 3;
            this.btn_TeacherRegistraion.UseVisualStyleBackColor = false;
            this.btn_TeacherRegistraion.Click += new System.EventHandler(this.btn_TeacherRegistraion_Click);
            // 
            // btn_StudentRegistration
            // 
            this.btn_StudentRegistration.BackColor = System.Drawing.Color.White;
            this.btn_StudentRegistration.BackgroundImage = global::SMSS.Properties.Resources.Student;
            this.btn_StudentRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_StudentRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StudentRegistration.Location = new System.Drawing.Point(303, 53);
            this.btn_StudentRegistration.Name = "btn_StudentRegistration";
            this.btn_StudentRegistration.Size = new System.Drawing.Size(134, 132);
            this.btn_StudentRegistration.TabIndex = 1;
            this.btn_StudentRegistration.UseVisualStyleBackColor = false;
            this.btn_StudentRegistration.Click += new System.EventHandler(this.btn_StudentRegistration_Click);
            // 
            // frmMainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 636);
            this.Controls.Add(this.btn_Course);
            this.Controls.Add(this.btn_Class);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_UserRegistration);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_FeeForm);
            this.Controls.Add(this.btn_TeacherRegistraion);
            this.Controls.Add(this.btn_StudentRegistration);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.Name = "frmMainInterface";
            this.Load += new System.EventHandler(this.frmMainInterface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_UserRegistration;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_FeeForm;
        private System.Windows.Forms.Button btn_TeacherRegistraion;
        private System.Windows.Forms.Button btn_StudentRegistration;
        private System.Windows.Forms.Button btn_Class;
        private System.Windows.Forms.Button btn_Course;
    }
}

