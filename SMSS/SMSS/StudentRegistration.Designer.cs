namespace SMSS
{
    partial class frmStudent
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Student_DOR = new System.Windows.Forms.DateTimePicker();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Student_DOB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_StudentFatherID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_StudentFatherName = new System.Windows.Forms.TextBox();
            this.txt_StudentLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StudentFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_CourseFee = new System.Windows.Forms.ComboBox();
            this.cmb_Teacher = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_StudentMobileNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_StudentEmailID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_FeePaid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.Course = new System.Windows.Forms.Label();
            this.txt_StudentAddress = new System.Windows.Forms.TextBox();
            this.cmb_Class = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.img_Box = new System.Windows.Forms.PictureBox();
            this.grid_Student = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(50, 369);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(153, 40);
            this.btn_Close.TabIndex = 20;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Address :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Course Fee :";
            // 
            // Student_DOR
            // 
            this.Student_DOR.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_DOR.CustomFormat = "dd/MM/yyyy";
            this.Student_DOR.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_DOR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Student_DOR.Location = new System.Drawing.Point(494, 131);
            this.Student_DOR.Name = "Student_DOR";
            this.Student_DOR.Size = new System.Drawing.Size(263, 26);
            this.Student_DOR.TabIndex = 6;
            this.Student_DOR.Value = new System.DateTime(2017, 11, 24, 0, 0, 0, 0);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(50, 322);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(153, 40);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(50, 274);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(153, 40);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(50, 227);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(153, 40);
            this.btn_Insert.TabIndex = 17;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date Of Reg. :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date Of birth";
            // 
            // Student_DOB
            // 
            this.Student_DOB.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_DOB.CustomFormat = "dd/MM/yyyy";
            this.Student_DOB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Student_DOB.Location = new System.Drawing.Point(112, 130);
            this.Student_DOB.Name = "Student_DOB";
            this.Student_DOB.Size = new System.Drawing.Size(263, 26);
            this.Student_DOB.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Class :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(402, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 33);
            this.label14.TabIndex = 32;
            this.label14.Text = "Student Portal";
            // 
            // txt_StudentFatherID
            // 
            this.txt_StudentFatherID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentFatherID.Location = new System.Drawing.Point(494, 84);
            this.txt_StudentFatherID.Name = "txt_StudentFatherID";
            this.txt_StudentFatherID.Size = new System.Drawing.Size(263, 26);
            this.txt_StudentFatherID.TabIndex = 4;
            this.txt_StudentFatherID.TextChanged += new System.EventHandler(this.txt_StudentFatherID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Father ID :";
            // 
            // txt_StudentFatherName
            // 
            this.txt_StudentFatherName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentFatherName.Location = new System.Drawing.Point(112, 81);
            this.txt_StudentFatherName.Name = "txt_StudentFatherName";
            this.txt_StudentFatherName.Size = new System.Drawing.Size(263, 26);
            this.txt_StudentFatherName.TabIndex = 3;
            // 
            // txt_StudentLastName
            // 
            this.txt_StudentLastName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentLastName.Location = new System.Drawing.Point(494, 35);
            this.txt_StudentLastName.Name = "txt_StudentLastName";
            this.txt_StudentLastName.Size = new System.Drawing.Size(263, 26);
            this.txt_StudentLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name :";
            // 
            // txt_StudentFirstName
            // 
            this.txt_StudentFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentFirstName.Location = new System.Drawing.Point(112, 35);
            this.txt_StudentFirstName.Name = "txt_StudentFirstName";
            this.txt_StudentFirstName.Size = new System.Drawing.Size(263, 26);
            this.txt_StudentFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_CourseFee);
            this.groupBox1.Controls.Add(this.cmb_Teacher);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_StudentMobileNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_StudentEmailID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_FeePaid);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_Balance);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cmb_Gender);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_Course);
            this.groupBox1.Controls.Add(this.Course);
            this.groupBox1.Controls.Add(this.txt_StudentAddress);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Student_DOR);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_Class);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Student_DOB);
            this.groupBox1.Controls.Add(this.txt_StudentFatherID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_StudentFatherName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_StudentLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_StudentFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 424);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // cmb_CourseFee
            // 
            this.cmb_CourseFee.Enabled = false;
            this.cmb_CourseFee.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CourseFee.FormattingEnabled = true;
            this.cmb_CourseFee.Location = new System.Drawing.Point(111, 266);
            this.cmb_CourseFee.Name = "cmb_CourseFee";
            this.cmb_CourseFee.Size = new System.Drawing.Size(165, 26);
            this.cmb_CourseFee.TabIndex = 13;
            // 
            // cmb_Teacher
            // 
            this.cmb_Teacher.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Teacher.FormattingEnabled = true;
            this.cmb_Teacher.Location = new System.Drawing.Point(578, 215);
            this.cmb_Teacher.Name = "cmb_Teacher";
            this.cmb_Teacher.Size = new System.Drawing.Size(179, 26);
            this.cmb_Teacher.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(514, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 18);
            this.label16.TabIndex = 42;
            this.label16.Text = "Teacher :";
            // 
            // txt_StudentMobileNo
            // 
            this.txt_StudentMobileNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentMobileNo.Location = new System.Drawing.Point(363, 175);
            this.txt_StudentMobileNo.Name = "txt_StudentMobileNo";
            this.txt_StudentMobileNo.Size = new System.Drawing.Size(143, 26);
            this.txt_StudentMobileNo.TabIndex = 8;
            this.txt_StudentMobileNo.TextChanged += new System.EventHandler(this.txt_StudentMobileNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Mobile No :";
            // 
            // txt_StudentEmailID
            // 
            this.txt_StudentEmailID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentEmailID.Location = new System.Drawing.Point(111, 174);
            this.txt_StudentEmailID.Name = "txt_StudentEmailID";
            this.txt_StudentEmailID.Size = new System.Drawing.Size(165, 26);
            this.txt_StudentEmailID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email ID:";
            // 
            // txt_FeePaid
            // 
            this.txt_FeePaid.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FeePaid.Location = new System.Drawing.Point(363, 266);
            this.txt_FeePaid.Name = "txt_FeePaid";
            this.txt_FeePaid.Size = new System.Drawing.Size(143, 26);
            this.txt_FeePaid.TabIndex = 14;
            this.txt_FeePaid.TextChanged += new System.EventHandler(this.txt_FeePaid_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(298, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 36;
            this.label12.Text = "Fee Paid :";
            // 
            // txt_Balance
            // 
            this.txt_Balance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Balance.Location = new System.Drawing.Point(578, 265);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.ReadOnly = true;
            this.txt_Balance.Size = new System.Drawing.Size(179, 26);
            this.txt_Balance.TabIndex = 15;
            this.txt_Balance.TextChanged += new System.EventHandler(this.txt_Balance_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(519, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 18);
            this.label15.TabIndex = 34;
            this.label15.Text = "Balance :";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Location = new System.Drawing.Point(578, 174);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(179, 26);
            this.cmb_Gender.TabIndex = 9;
            this.cmb_Gender.SelectedIndexChanged += new System.EventHandler(this.cmb_Gender_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(518, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Gender :";
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Location = new System.Drawing.Point(363, 221);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(141, 26);
            this.cmb_Course.TabIndex = 11;
            this.cmb_Course.SelectedIndexChanged += new System.EventHandler(this.cmb_Course_SelectedIndexChanged);
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.Location = new System.Drawing.Point(299, 224);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(57, 18);
            this.Course.TabIndex = 29;
            this.Course.Text = "Course :";
            // 
            // txt_StudentAddress
            // 
            this.txt_StudentAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentAddress.Location = new System.Drawing.Point(112, 311);
            this.txt_StudentAddress.Multiline = true;
            this.txt_StudentAddress.Name = "txt_StudentAddress";
            this.txt_StudentAddress.Size = new System.Drawing.Size(645, 99);
            this.txt_StudentAddress.TabIndex = 16;
            // 
            // cmb_Class
            // 
            this.cmb_Class.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Class.FormattingEnabled = true;
            this.cmb_Class.Location = new System.Drawing.Point(112, 220);
            this.cmb_Class.Name = "cmb_Class";
            this.cmb_Class.Size = new System.Drawing.Size(164, 26);
            this.cmb_Class.TabIndex = 10;
            this.cmb_Class.SelectedIndexChanged += new System.EventHandler(this.cmb_Class_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Father Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.img_Box);
            this.groupBox2.Controls.Add(this.btn_Close);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_Insert);
            this.groupBox2.Location = new System.Drawing.Point(808, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 424);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            // 
            // img_Box
            // 
            this.img_Box.BackgroundImage = global::SMSS.Properties.Resources.img;
            this.img_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_Box.InitialImage = null;
            this.img_Box.Location = new System.Drawing.Point(48, 34);
            this.img_Box.Name = "img_Box";
            this.img_Box.Size = new System.Drawing.Size(155, 162);
            this.img_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Box.TabIndex = 9;
            this.img_Box.TabStop = false;
            this.img_Box.DoubleClick += new System.EventHandler(this.imb_Box_DoubleClick);
            // 
            // grid_Student
            // 
            this.grid_Student.AllowUserToAddRows = false;
            this.grid_Student.AllowUserToDeleteRows = false;
            this.grid_Student.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.grid_Student.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_Student.Location = new System.Drawing.Point(12, 473);
            this.grid_Student.Name = "grid_Student";
            this.grid_Student.ReadOnly = true;
            this.grid_Student.Size = new System.Drawing.Size(1051, 177);
            this.grid_Student.TabIndex = 33;
            this.grid_Student.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Student_RowHeaderMouseDoubleClick);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 664);
            this.Controls.Add(this.grid_Student);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmStudent";
            this.Resizable = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Student_DOR;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Student_DOB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_StudentFatherID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_StudentFatherName;
        private System.Windows.Forms.TextBox txt_StudentLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StudentFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.DataGridView grid_Student;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.TextBox txt_FeePaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_Teacher;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_StudentMobileNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_StudentEmailID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_StudentAddress;
        private System.Windows.Forms.PictureBox img_Box;
        private System.Windows.Forms.ComboBox cmb_CourseFee;
        private System.Windows.Forms.ComboBox cmb_Class;
    }
}