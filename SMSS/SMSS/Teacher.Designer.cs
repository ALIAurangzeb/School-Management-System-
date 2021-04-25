namespace SMSS
{
    partial class frmTeacher
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
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TeacherAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TeacherSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TeacherCNIC = new System.Windows.Forms.TextBox();
            this.txt_TeacherLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TeacherMobileNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_CourseID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_CourseName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_Teacher = new System.Windows.Forms.DataGridView();
            this.txt_TeacherFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.img_Box = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Teacher)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(338, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 33);
            this.label14.TabIndex = 39;
            this.label14.Text = "Teacher Portal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TeacherAddress);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_TeacherSalary);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_TeacherCNIC);
            this.groupBox1.Controls.Add(this.txt_TeacherLastName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_TeacherMobileNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_CourseID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_CourseName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.grid_Teacher);
            this.groupBox1.Controls.Add(this.txt_TeacherFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 423);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher Details";
            // 
            // txt_TeacherAddress
            // 
            this.txt_TeacherAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherAddress.Location = new System.Drawing.Point(115, 147);
            this.txt_TeacherAddress.Name = "txt_TeacherAddress";
            this.txt_TeacherAddress.Size = new System.Drawing.Size(535, 26);
            this.txt_TeacherAddress.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "Address :";
            // 
            // txt_TeacherSalary
            // 
            this.txt_TeacherSalary.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherSalary.Location = new System.Drawing.Point(538, 108);
            this.txt_TeacherSalary.Name = "txt_TeacherSalary";
            this.txt_TeacherSalary.Size = new System.Drawing.Size(112, 26);
            this.txt_TeacherSalary.TabIndex = 7;
            this.txt_TeacherSalary.TextChanged += new System.EventHandler(this.txt_TeacherSalary_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Salary :";
            // 
            // txt_TeacherCNIC
            // 
            this.txt_TeacherCNIC.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherCNIC.Location = new System.Drawing.Point(115, 69);
            this.txt_TeacherCNIC.Name = "txt_TeacherCNIC";
            this.txt_TeacherCNIC.Size = new System.Drawing.Size(228, 26);
            this.txt_TeacherCNIC.TabIndex = 3;
            this.txt_TeacherCNIC.TextChanged += new System.EventHandler(this.txt_TeacherCNIC_TextChanged);
            // 
            // txt_TeacherLastName
            // 
            this.txt_TeacherLastName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherLastName.Location = new System.Drawing.Point(433, 31);
            this.txt_TeacherLastName.Name = "txt_TeacherLastName";
            this.txt_TeacherLastName.Size = new System.Drawing.Size(217, 26);
            this.txt_TeacherLastName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Last Name :";
            // 
            // txt_TeacherMobileNo
            // 
            this.txt_TeacherMobileNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherMobileNo.Location = new System.Drawing.Point(433, 72);
            this.txt_TeacherMobileNo.Name = "txt_TeacherMobileNo";
            this.txt_TeacherMobileNo.Size = new System.Drawing.Size(217, 26);
            this.txt_TeacherMobileNo.TabIndex = 4;
            this.txt_TeacherMobileNo.TextChanged += new System.EventHandler(this.txt_TeacherMobileNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mobile No :";
            // 
            // cmb_CourseID
            // 
            this.cmb_CourseID.Enabled = false;
            this.cmb_CourseID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CourseID.FormattingEnabled = true;
            this.cmb_CourseID.ItemHeight = 18;
            this.cmb_CourseID.Location = new System.Drawing.Point(330, 108);
            this.cmb_CourseID.Name = "cmb_CourseID";
            this.cmb_CourseID.Size = new System.Drawing.Size(137, 26);
            this.cmb_CourseID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Course ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "CNIC No :";
            // 
            // cmb_CourseName
            // 
            this.cmb_CourseName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CourseName.FormattingEnabled = true;
            this.cmb_CourseName.ItemHeight = 18;
            this.cmb_CourseName.Location = new System.Drawing.Point(117, 108);
            this.cmb_CourseName.Name = "cmb_CourseName";
            this.cmb_CourseName.Size = new System.Drawing.Size(126, 26);
            this.cmb_CourseName.TabIndex = 5;
            this.cmb_CourseName.SelectedIndexChanged += new System.EventHandler(this.cmb_CourseName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course :";
            // 
            // grid_Teacher
            // 
            this.grid_Teacher.AllowUserToAddRows = false;
            this.grid_Teacher.AllowUserToDeleteRows = false;
            this.grid_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Teacher.Location = new System.Drawing.Point(11, 193);
            this.grid_Teacher.Name = "grid_Teacher";
            this.grid_Teacher.ReadOnly = true;
            this.grid_Teacher.Size = new System.Drawing.Size(639, 220);
            this.grid_Teacher.TabIndex = 15;
            this.grid_Teacher.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Teacher_RowHeaderMouseDoubleClick);
            // 
            // txt_TeacherFirstName
            // 
            this.txt_TeacherFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherFirstName.Location = new System.Drawing.Point(115, 31);
            this.txt_TeacherFirstName.Name = "txt_TeacherFirstName";
            this.txt_TeacherFirstName.Size = new System.Drawing.Size(228, 26);
            this.txt_TeacherFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.img_Box);
            this.groupBox2.Controls.Add(this.btn_Close);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_Insert);
            this.groupBox2.Location = new System.Drawing.Point(685, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 423);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teacher Details";
            // 
            // img_Box
            // 
            this.img_Box.BackgroundImage = global::SMSS.Properties.Resources.img;
            this.img_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_Box.InitialImage = null;
            this.img_Box.Location = new System.Drawing.Point(15, 27);
            this.img_Box.Name = "img_Box";
            this.img_Box.Size = new System.Drawing.Size(155, 162);
            this.img_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Box.TabIndex = 19;
            this.img_Box.TabStop = false;
            this.img_Box.DoubleClick += new System.EventHandler(this.img_Box_DoubleClick);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(15, 369);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(153, 40);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(15, 321);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(153, 40);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(15, 274);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(153, 40);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(15, 225);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(153, 40);
            this.btn_Insert.TabIndex = 9;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 477);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmTeacher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Teacher)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TeacherMobileNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_CourseID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_CourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid_Teacher;
        private System.Windows.Forms.TextBox txt_TeacherFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txt_TeacherLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TeacherCNIC;
        private System.Windows.Forms.TextBox txt_TeacherSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TeacherAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox img_Box;
    }
}