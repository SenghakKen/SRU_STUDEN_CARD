using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRU_STUDEN_CARD
{
    public partial class frmAddStudent : Form
    {
        private StuDB db;
        
        
        public frmAddStudent(StuDB db)
        {
            InitializeComponent();
            this.db = db;
           
        }

        
        private void btadd_Click(object sender, EventArgs e)
        {
            if (CheckTextBox_Null(txt_id, "Please Input ID ") == -1) return;
            else if (CheckTextBox_Null(txt_Ename, "Please Input English Name ") == -1) return;
            else if (CheckTextBox_Null(txt_Kname, "Please Input Khmer Name ") == -1) return;
            else if (CheckComBoSelect(cbo_sex, "Select Sex ") == -1) return;
            else if (CheckComBoSelect(cbo_subject, "Select Sub") == -1) return;
            else if(CheckComBoSelect(cbo_degree,"Select Degree")==-1) return;
            else{
                if (db.chekID(txt_id.Text) == true)
                {
                    MessageBox.Show("ID already exist..."+txt_id.Text);
                    return;
                }
                else
                {
                    Student st = new Student(
                        new Person(txt_id.Text, txt_Ename.Text, txt_Kname.Text, cbo_sex.Text,
                        dtime_dob.Text), "", cbo_subject.Text, "", cbo_degree.Text, "");
                    db.Add_Student(st);// to DB
                    View_Student(dg_student, st);
                    ResetInput();
                }

            }

            

        }// End Method Add 1 Record
        //-------- Check data selected on ComboBox 
        private int CheckComBoSelect(ComboBox cb,string mess)
        {
           if (cb.SelectedIndex == 0)
            {
                MessageBox.Show(mess);
                cb.SelectedIndex = 0;
                cb.Focus();
                return -1;
            }
            return 1;


        }
        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            dtime_dob. Format = DateTimePickerFormat.Custom;
            dtime_dob.CustomFormat = "dd - MM - yyyy";
            dtime_dob.MaxDate = DateTime.Today;

            cbo_sex.SelectedIndex = 0;
            cbo_subject.SelectedIndex = 0;
            cbo_degree.SelectedIndex = 0;

        }
        private int CheckTextBox_Null(TextBox t, string msg)
        {
            if (t.Text == "")
            {
                MessageBox.Show(msg);
                t.Focus();
                return -1;
            }
            return 1;
        }// end Textbox
        private void View_Student(DataGridView dg,Student st)
        {
          dg.Rows.Add(dg.Rows.Count,st.Id,st.E_Name,st.K_Name,st.Sex,st.Dob,
              st.e_sub,st.e_degree);
        }
        private void View_Student(DataGridView dg, List<Student> stu)
        {
            dg.Rows.Clear();
            foreach(Student st in stu)
             View_Student(dg,st);
        }
        private void ResetInput()
        {
            txt_Kname.Text = "";
            txt_Ename.Text = "";
            cbo_sex.SelectedIndex = 0;
            cbo_subject.SelectedIndex=0;
            cbo_degree.SelectedIndex = 0;
            txt_id.SelectAll();
            txt_id.Focus();
        }// end ResetInput

        private void btatact_Click(object sender, EventArgs e)
        {
            View_Student(dg_student, new ReadWriteDB(db).ReadCSV());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            View_Student(dg_student, db.FilterId(textBox1.Text));
        }
    }
}
