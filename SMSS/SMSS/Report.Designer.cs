namespace SMSS
{
    partial class Report
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
            this.grid_StudentRecord = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Teacher = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.Course = new System.Windows.Forms.Label();
            this.cmb_Class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_StudentFatherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_StudentLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StudentFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.pdf_Print = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_StudentRecord
            // 
            this.grid_StudentRecord.AllowUserToAddRows = false;
            this.grid_StudentRecord.AllowUserToDeleteRows = false;
            this.grid_StudentRecord.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.grid_StudentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_StudentRecord.Location = new System.Drawing.Point(10, 293);
            this.grid_StudentRecord.Name = "grid_StudentRecord";
            this.grid_StudentRecord.ReadOnly = true;
            this.grid_StudentRecord.Size = new System.Drawing.Size(590, 194);
            this.grid_StudentRecord.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Teacher);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmb_Course);
            this.groupBox1.Controls.Add(this.Course);
            this.groupBox1.Controls.Add(this.cmb_Class);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_StudentFatherName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_StudentLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_StudentFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 246);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Record";
            // 
            // cmb_Teacher
            // 
            this.cmb_Teacher.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Teacher.FormattingEnabled = true;
            this.cmb_Teacher.Location = new System.Drawing.Point(117, 208);
            this.cmb_Teacher.Name = "cmb_Teacher";
            this.cmb_Teacher.Size = new System.Drawing.Size(266, 26);
            this.cmb_Teacher.TabIndex = 6;
            this.cmb_Teacher.SelectedIndexChanged += new System.EventHandler(this.cmb_Teacher_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 18);
            this.label16.TabIndex = 54;
            this.label16.Text = "Teacher :";
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Location = new System.Drawing.Point(117, 168);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(266, 26);
            this.cmb_Course.TabIndex = 5;
            this.cmb_Course.SelectedIndexChanged += new System.EventHandler(this.cmb_Course_SelectedIndexChanged);
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.Location = new System.Drawing.Point(17, 175);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(57, 18);
            this.Course.TabIndex = 52;
            this.Course.Text = "Course :";
            // 
            // cmb_Class
            // 
            this.cmb_Class.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Class.FormattingEnabled = true;
            this.cmb_Class.ItemHeight = 18;
            this.cmb_Class.Location = new System.Drawing.Point(117, 129);
            this.cmb_Class.Name = "cmb_Class";
            this.cmb_Class.Size = new System.Drawing.Size(266, 26);
            this.cmb_Class.TabIndex = 4;
            this.cmb_Class.SelectedIndexChanged += new System.EventHandler(this.cmb_Class_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 50;
            this.label8.Text = "Class :";
            // 
            // txt_StudentFatherName
            // 
            this.txt_StudentFatherName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentFatherName.Location = new System.Drawing.Point(116, 93);
            this.txt_StudentFatherName.Name = "txt_StudentFatherName";
            this.txt_StudentFatherName.Size = new System.Drawing.Size(267, 26);
            this.txt_StudentFatherName.TabIndex = 3;
            this.txt_StudentFatherName.TextChanged += new System.EventHandler(this.txt_StudentFatherName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Father Name :";
            // 
            // txt_StudentLastName
            // 
            this.txt_StudentLastName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentLastName.Location = new System.Drawing.Point(116, 55);
            this.txt_StudentLastName.Name = "txt_StudentLastName";
            this.txt_StudentLastName.Size = new System.Drawing.Size(267, 26);
            this.txt_StudentLastName.TabIndex = 2;
            this.txt_StudentLastName.TextChanged += new System.EventHandler(this.txt_StudentLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Last Name :";
            // 
            // txt_StudentFirstName
            // 
            this.txt_StudentFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentFirstName.Location = new System.Drawing.Point(116, 17);
            this.txt_StudentFirstName.Name = "txt_StudentFirstName";
            this.txt_StudentFirstName.Size = new System.Drawing.Size(267, 26);
            this.txt_StudentFirstName.TabIndex = 1;
            this.txt_StudentFirstName.TextChanged += new System.EventHandler(this.txt_StudentFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "First Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.btn_Close);
            this.groupBox2.Controls.Add(this.btn_Excel);
            this.groupBox2.Controls.Add(this.pdf_Print);
            this.groupBox2.Location = new System.Drawing.Point(420, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 246);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Record";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(12, 53);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(153, 40);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(12, 193);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(153, 40);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(12, 146);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(153, 40);
            this.btn_Excel.TabIndex = 9;
            this.btn_Excel.Text = "Export Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // pdf_Print
            // 
            this.pdf_Print.Location = new System.Drawing.Point(12, 100);
            this.pdf_Print.Name = "pdf_Print";
            this.pdf_Print.Size = new System.Drawing.Size(153, 40);
            this.pdf_Print.TabIndex = 8;
            this.pdf_Print.Text = "Export PDF";
            this.pdf_Print.UseVisualStyleBackColor = true;
            this.pdf_Print.Click += new System.EventHandler(this.pdf_Print_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(202, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 33);
            this.label14.TabIndex = 37;
            this.label14.Text = "Student Record";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 496);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_StudentRecord);
            this.MaximizeBox = false;
            this.Name = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_StudentRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Teacher;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.ComboBox cmb_Class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_StudentFatherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_StudentLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StudentFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button pdf_Print;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label14;
    }
}