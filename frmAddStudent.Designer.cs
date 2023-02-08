namespace SRU_STUDEN_CARD
{
    partial class frmAddStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btatact = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btnew = new System.Windows.Forms.Button();
            this.cbo_degree = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Kname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_subject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtime_dob = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_sex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dg_student = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 2);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD STUDENTS....";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btatact);
            this.groupBox1.Controls.Add(this.btadd);
            this.groupBox1.Controls.Add(this.btnew);
            this.groupBox1.Controls.Add(this.cbo_degree);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Kname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbo_subject);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtime_dob);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_sex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Ename);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student information";
            // 
            // btatact
            // 
            this.btatact.Location = new System.Drawing.Point(443, 76);
            this.btatact.Name = "btatact";
            this.btatact.Size = new System.Drawing.Size(75, 23);
            this.btatact.TabIndex = 16;
            this.btatact.Text = "attact";
            this.btatact.UseVisualStyleBackColor = true;
            this.btatact.Click += new System.EventHandler(this.btatact_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(443, 47);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 15;
            this.btadd.Text = "ADD";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btnew
            // 
            this.btnew.Location = new System.Drawing.Point(443, 18);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(75, 23);
            this.btnew.TabIndex = 14;
            this.btnew.Text = "New";
            this.btnew.UseVisualStyleBackColor = true;
            // 
            // cbo_degree
            // 
            this.cbo_degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_degree.FormattingEnabled = true;
            this.cbo_degree.Items.AddRange(new object[] {
            "--Select--",
            "Associate",
            "Bachelor",
            "Master"});
            this.cbo_degree.Location = new System.Drawing.Point(260, 94);
            this.cbo_degree.Name = "cbo_degree";
            this.cbo_degree.Size = new System.Drawing.Size(113, 21);
            this.cbo_degree.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Degree";
            // 
            // txt_Kname
            // 
            this.txt_Kname.Location = new System.Drawing.Point(259, 43);
            this.txt_Kname.Name = "txt_Kname";
            this.txt_Kname.Size = new System.Drawing.Size(148, 20);
            this.txt_Kname.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Khmer";
            // 
            // cbo_subject
            // 
            this.cbo_subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_subject.FormattingEnabled = true;
            this.cbo_subject.Items.AddRange(new object[] {
            "--Select---",
            "Agronomy",
            "Rural Development",
            "Animal Science and Veterinary",
            "Management",
            "Accounting",
            "Marketing",
            "Finance and Banking",
            "Public Administration",
            "English Literature",
            "Translation and Interpretation",
            "Mathematics",
            "Computer Science"});
            this.cbo_subject.Location = new System.Drawing.Point(69, 96);
            this.cbo_subject.Name = "cbo_subject";
            this.cbo_subject.Size = new System.Drawing.Size(113, 21);
            this.cbo_subject.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Subject";
            // 
            // dtime_dob
            // 
            this.dtime_dob.Location = new System.Drawing.Point(259, 69);
            this.dtime_dob.Name = "dtime_dob";
            this.dtime_dob.Size = new System.Drawing.Size(148, 20);
            this.dtime_dob.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "DOB";
            // 
            // cbo_sex
            // 
            this.cbo_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sex.FormattingEnabled = true;
            this.cbo_sex.Items.AddRange(new object[] {
            "--Select--",
            "Male",
            "Female"});
            this.cbo_sex.Location = new System.Drawing.Point(69, 69);
            this.cbo_sex.Name = "cbo_sex";
            this.cbo_sex.Size = new System.Drawing.Size(87, 21);
            this.cbo_sex.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sex";
            // 
            // txt_Ename
            // 
            this.txt_Ename.Location = new System.Drawing.Point(69, 44);
            this.txt_Ename.Name = "txt_Ename";
            this.txt_Ename.Size = new System.Drawing.Size(148, 20);
            this.txt_Ename.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(69, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(148, 20);
            this.txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Filter by ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(608, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dg_student
            // 
            this.dg_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dg_student.Location = new System.Drawing.Point(6, 178);
            this.dg_student.Name = "dg_student";
            this.dg_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_student.Size = new System.Drawing.Size(825, 238);
            this.dg_student.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "K-Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sex";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DOB";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Subject";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Degree";
            this.Column8.Name = "Column8";
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(959, 462);
            this.Controls.Add(this.dg_student);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddStudent";
            this.Text = "frmAddStudent";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btatact;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.ComboBox cbo_degree;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Kname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_subject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtime_dob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dg_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}