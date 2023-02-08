using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRU_STUDEN_CARD
{
    [Serializable]
    public class Student:Person
    {
        public string k_sub { get; set; }
        public string e_sub { get; set; }
        public string k_degree { get; set; }
        public string e_degree { get; set; }
        public string print_date { get; set; }
        //------------------
        public Student(Person p,string ksub,string esub,string kdegree,
           string edegree, string pdate) : base(p.Id, p.E_Name, p.K_Name, p.Sex, p.Dob)
        {
            this.k_sub = ksub;
            this.e_sub = esub;
            this.k_degree = kdegree;
            this.e_degree = edegree;
            this.print_date = pdate;
        }// end constructor


    }
}
