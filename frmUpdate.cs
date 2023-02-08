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
    public partial class frmUpdate : Form
    {
        private Student st;
        private StuDB db;
        public frmUpdate(Student st,StuDB db)
        {
            InitializeComponent();
            this.st = st;
            this.db = db;
            setData(st);

        }
        //---------set Data ----
        private void setData(Student st)
        {
            txt_id.Text = st.Id;
            txt_Ename.Text = st.K_Name;
            txt_Kname.Text = st.E_Name;
            //cbo_degree.Text = st.e_degree;
            //cbo_sex.Text = st.Sex;
            //cbo_subject.Text = st.e_sub;
            bt_update.Focus();

        }
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            dtime_dob.Format = DateTimePickerFormat.Custom;
            dtime_dob.CustomFormat = "dd - MM - yyyy";
            dtime_dob.MaxDate = DateTime.Today;
            cbo_sex.SelectedIndex = 0;
            cbo_subject.SelectedIndex = 0;
            cbo_degree.SelectedIndex = 0;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Update ID : " + txt_id.Text, "Form Update",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                st = new Student(new Person(txt_id.Text, txt_Ename.Text,
                    txt_Kname.Text, cbo_sex.Text, dtime_dob.Text), "", cbo_subject.Text,
                    "", cbo_degree.Text, "");
                db.UpdateStudent(st);
                db.ViewStudent(frmView.instand.getDataGrid(), db.GetStudents());
                //Dispose();
            }
        }// end function update
    }
}
