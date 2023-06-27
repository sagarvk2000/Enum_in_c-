using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// public enum Streams { CS,IT,Electrical,Electronic,Mach, Civil};
//Use above declared enum in Student class

namespace Enum
{
    public enum Streams { CS, IT, Electrical, Electronic, Mech, Civil };
    public class Student
    {
        private int rollno,m1,m2,m3;
        private string name;
        double percentage,total;
        private Streams streams;
        public Student(string name, int rollno,int m1,int m2,int m3,Streams streams)
        {
            this.name = name;
            this.rollno = rollno;
            
            this.streams = streams;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public void Calculate()
        {
            total = m1 + m2 + m3;
            percentage = (total / 300) * 100;
        }

        public override string ToString()
        {
            return $"The name is = {name}\n The roll no is ={rollno}\n The percentage is ={percentage}.\n stream is={streams}";
        }
    }
}
