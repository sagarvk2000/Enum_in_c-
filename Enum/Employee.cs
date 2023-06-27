using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class Employee
    {
        public enum Dept { HR = 101, Admin, Sales, Development, Testing }

        public string name;
        public int id;
        public double bs, hra, ta, da, pf, gs, total;
        public static int count;
        private Dept dept;
        public Employee(string name, int bs, Dept dept)
        {
            count++;
            this.name = name;
            this.bs = bs;
            this.id = count;
            this.dept = dept;
        }
        public static int Getcount()
        {
            return count;
        }
        public void CalculateSalary()

        {
            hra = bs * 0.40;

            ta = bs * 0.20;

            da = bs * 0.15;

            pf = bs * 0.12;

            total = (bs + hra + ta + da);

            gs = (total) - pf;

        }
        public override string ToString()
        {
            return $"Name is {name},\nId is {count},\nTotal salary is {total},\nGross salary is {gs}, emp dept is={dept}";
        }
    }
}
