using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;

namespace Student_Management_System
{
    class DataAccess
    {
        public List<Student> GetStudents(string Surname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("StudentDB")))
            {
                return connection.Query<Student>($"select * from Student where Surname = '{ Surname }'").ToList();
            }
        }
    }
}
