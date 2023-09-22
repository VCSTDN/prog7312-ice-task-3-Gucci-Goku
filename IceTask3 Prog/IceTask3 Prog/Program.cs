using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3_Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            Random ran = new Random();
            string[] surname = { "Smith","Green","Jackson", "Blue","Robinson","Streep","Depp","White","Miller","Rock"};
            List<Employee> list = new List<Employee>();

            Random random = new Random();

          
          

            for (int i = 0; i < 9; i++)
            {
                // Generate a random index within the range of the array's length
                int randomIndex = random.Next(0, surname.Length);

                // Use the random index to access a random string from the array
                string randomString = surname[randomIndex];

                list.Add(new Employee(ran.Next(1, 5), randomString));
               
            }

            List<Employee> sortedList = SortEmployees(list);

            foreach (var employee in sortedList)
            {
               
                Console.WriteLine($"ID: {employee.departmentID}, Surname: {employee.empSurname}");
            }


            Console.ReadLine();

        }
        public static List<Employee> SortEmployees(List<Employee> employees)
        {
            return employees.OrderBy(e => e.departmentID).ThenBy(e => e.empSurname).ToList();
        }

    }
}
