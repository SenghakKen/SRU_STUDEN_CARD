using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRU_STUDEN_CARD
{
    [Serializable]
    public class Person
    {
        public string Id { get; set; }
        public string E_Name { get; set; }
        public string K_Name { get; set; }
        public string Sex { set; get; }
        public string Dob { set; get; }
        //- Contructor
        public Person(string id, string e_name,string k_name,string sex,string dob)
        {
            Id = id; 
            E_Name = e_name; 
            K_Name = k_name;
            Sex = sex;
            Dob = dob;
        }// end constructor
           
    }
}
