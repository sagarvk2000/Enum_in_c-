using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee("home", 24000,Employee.Dept.HR);
            //emp1.CalculateSalary();
            //Console.WriteLine(emp1.ToString());

            //Employee emp2 = new Employee("om", 34000,Employee.Dept.Development);
            //emp2.CalculateSalary();
            //Console.WriteLine(emp2);

            Student s1 = new Student("Nir", 55,66,55,99, Streams.Civil);
            s1.Calculate();
            Console.WriteLine(s1.ToString());

            Student s2 = new Student("sagar", 15,65,98,45, Streams.Mech);
            s2.Calculate();
            Console.WriteLine("\n"+s2.ToString());
        }
    }

}
