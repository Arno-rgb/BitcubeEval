using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Classes
{
    public interface Person
    {
         int id { get; set; }
         string Surname { get; set; }
         string DateofBirth { get; set; }
         string Email { get; set; }
         string FirstName { get; set; }
         string MiddleName { get; set; }
         string Degree { get; set; }
        
    }
}
