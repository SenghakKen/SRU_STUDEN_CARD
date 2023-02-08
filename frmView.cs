using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SRU_STUDEN_CARD
{
    public partial class frmView : Form
    {
        private StuDB db;
        public static frmView instand;
        public frmView(StuDB db)
        {
            InitializeComponent();
            this.db = db;
            instand = this;
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            dg_students.MultiSelect = true;
            db.ViewStudent(dg_students, db.GetStudents());
            bt_delete.Enabled = false;
            bt_update.Enabled = false;
        }

        private void txt_search_id_TextChanged(object sender, EventArgs e)
        {
            db.ViewStudent(dg_students, db.FilterId(txt_search_id.Text));
        }

        private void txt_search_name_TextChanged(object sender, EventArgs e)
        {
            db.ViewStudent(dg_students, db.FilterName(txt_search_name.Text));
        }
        string getId="";
        private void dg_students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            bt_update.Enabled = true;
            bt_delete.Enabled = true;
            int index = dg_students.SelectedRows[0].Index;
            getId = dg_students.Rows[index].Cells[1].Value.ToString();
            

        }

        private void dg_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
//----------------------------
        private void bt_delete_Click(object sender, EventArgs e)
        {
            List<string> delet_id = new List<string>();
            DialogResult rs;
            foreach (DataGridViewRow r in dg_students.Rows)
            {
                bool isSelected = Convert.ToBoolean(r.Cells["dgChech"].Value);
                if (isSelected)
                {
                    delet_id.Add(r.Cells[1].Value.ToString());
                }                                 
            }

            //MessageBox.Show(delet_id.Count + "");
            //---------------
            if (delet_id.Count > 1)
            {
                rs = MessageBox.Show($"Delect : {delet_id.Count} Records  " , "Delete Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    db.DeleteStudent(delet_id);
                    db.ViewStudent(dg_students, db.GetStudents());
                    getId = "";
                }
            }
            else
            {
                rs = MessageBox.Show("Delect 1 Record : id " + getId, "Delete Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes){
                    DeletStudent(getId);
                    db.ViewStudent(dg_students, db.GetStudents());
                    getId = "";
                }
            }
            //-----------
            bt_update.Enabled = false ;
            bt_delete.Enabled = false;

        }
//-----------------------------
        private void DeletStudent(string id)
        {
            db.DeleteStudent(id);
            db.ViewStudent(dg_students, db.GetStudents());

        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (getId.Equals("")) return;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
            MessageBox.Show("Upate Id : "+getId);
            new frmUpdate(db.getStudent(getId),db).Show();
        }
        //------
        public DataGridView getDataGrid() { return dg_students; }
    }// end View class
}
