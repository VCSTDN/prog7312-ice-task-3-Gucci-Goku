using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3_Prog
{
    internal class Employee
    {
        

        public int departmentID;
        public string empSurname;

        public Employee(int departmentID, string surname)
        {
            this.departmentID = departmentID;
            this.empSurname = surname;
        }
    }
}
