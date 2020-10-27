using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Classes
{
     public class Lecturer : Person
     {
            public int id { get; set; }
            public string Surname { get; set; }
            public string DateofBirth { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string ForeName
            {
                get { return $"{FirstName[0]}{MiddleName[0]}"; }
            }
            public string FullName
            {
                get { return $" {ForeName} {Surname}"; }
            }
            public string Degree { get; set; }
     }
}
