using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SRU_STUDEN_CARD
{
    public class StuDB
    {
        private List<Student> db = new List<Student>();
        public void Add_Student(Student stu) { db.Add(stu); }
        public void Add_Student(List<Student> ls)
        {
            db.AddRange(ls);
        }


        public List<Student> GetStudents() { return db; }
        // Override 
        public bool checkID(Student stu)
        {
            foreach (Student s in db)
                if (s.Id.Equals(s.Id)) return true;
            return false;
        }
        public bool chekID(string id)
        {
            foreach (Student s in db)
            {
                if (s.Id.Equals(id)) return true;
            }
            return false;
        }
        public List<Student> FilterId(string id)
        {
            List<Student> ls = new List<Student>();
            if (id.Length == 0) return db;
            foreach (Student s in db)
            {
                string i = s.Id;
                if (id.Length > i.Length) continue;
                i = i.Substring(0, id.Length);
                if (i.Equals(id)) ls.Add(s);
            }
            return ls;
        }
        public List<Student> FilterName(string name)
        {
            List<Student> ls = new List<Student>();
            name = name.ToUpper();
            if (name.Length == 0) return db;
            foreach (Student s in db)
            {
                string n = s.K_Name.ToUpper();
                if (name.Length > n.Length) continue;
                n = n.Substring(0, name.Length);
                if (n.Equals(name)) ls.Add(s);
            }
            return ls;
        }
        public void ViewStudent(DataGridView dg, List<Student> ls)
        {
            dg.Rows.Clear();
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (Student s in ls)
                dg.Rows.Add(dg.Rows.Count+1, s.Id, s.K_Name, s.E_Name,s.Sex, 
                    s.e_sub, s.e_degree,s.print_date);
        }
        public Student getStudent(int index){ return db[index]; }
        public Student getStudent(string id)
        {
            foreach(Student s in db)
            {
                if (s.Id.Equals(id)) return s;
            }
            return null;
        }
        public void DeleteStudent(string id)
        {
            db.Remove(getStudent(id));
        }
        public void DeleteStudent(List<string>id)
        {
            for (int i = 0; i < id.Count; i++)
                db.Remove(getStudent(id[i]));
        }     
        public void DeletStudent(int index) { db.RemoveAt(index); }
        public void UpdateStudent(Student st)
        {
            for(int i =0; i<db.Count;i++)
            {
                if (st.Id.Equals(db[i].Id))
                {
                    db[i] = st;
                    break;
                }
            }
        }// end upate 

    }
}
