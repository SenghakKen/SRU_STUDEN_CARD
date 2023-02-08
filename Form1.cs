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
    public partial class Form1 : Form
    {
        private bool back = true;
        private Form active;
        private StuDB db = new StuDB();

        //----------------
        public Form1()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if(back== false)
            {
                back= true;
                btBack.Image = Properties.Resources.next;
                timer.Start();
            }
            else
            {
                back = false;
                btBack.Image = Properties.Resources._1_back_to_26px;
                timer.Start();
            }
        }// end back button

        private void timer_Tick(object sender, EventArgs e)
        {
            if (back)
            {
                if (p_Navigation.Width > 150)
                    timer.Stop();
                p_Navigation.Width += 2;
            }
            else
            {
                if (p_Navigation.Width < 38)
                    timer.Stop();
                p_Navigation.Width -= 2;
            }
        }// end Timer

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //----------Check Textbox
       
        //-----------Load Form 
        private void LoadForm(Form f)
        {
            if (active != null) active.Close();
            active = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            p_Contain.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }//--- End Method Load Form

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new frmAddStudent(db));
        }

        private void p_Navigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new frmView(db));
        }
    }
}
