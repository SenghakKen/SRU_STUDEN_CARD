using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SRU_STUDEN_CARD
{
    public class ReadWriteDB
    {
        private StuDB db;
        public static ReadWriteDB instand;
        public ReadWriteDB(StuDB db)
        {
            this.db = db;
            instand = this;
        }
        public List<Student> ReadCSV()
        {
            List<Student> students = new List<Student>();
            OpenFileDialog opfdia = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (opfdia.ShowDialog() == DialogResult.OK)
            {
                string filePath = opfdia.FileName;
                StreamReader reader = null;
                if (File.Exists(filePath))
                {
                    try
                    {
                        reader = new StreamReader(File.OpenRead(filePath));
                        List<string> ls = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            string str = reader.ReadLine();
                            var store = str.Split(',');
                            foreach (var item in store)
                            {
                                ls.Add(item);
                            }

                        }// end while
                        reader.Close();
                        // add data to DB

                        for (int i = 9; i < ls.Count;)
                        {
                            if (db.chekID(ls[i]) == true)
                            {
                                for (int j = 0; j < 9; j++)
                                    ls.RemoveAt(i);
                            }
                            else
                                i += 9;
                            
                        }
                        for(int i =9; i<ls.Count; i+=9)
                            students.Add(new Student(new Person(ls[i + 0], ls[i + 1], ls[i + 2],
                                       ls[i + 3], ls[4+i]), ls[8 + i], ls[7 + i], ls[6 + i], ls[5+i],
                                       ""));

                        db.Add_Student(students);
                    }
                    catch (Exception exp) { MessageBox.Show("Aother file is running " + exp.ToString()); }

                }// end if check file
            }// End if Dialog

            return students;
        }// end function
        //--------------------------
    }
}
