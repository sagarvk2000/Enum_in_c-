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
        private int rollno;
        private string name;
        double percentage;
        private Streams streams;
        public Student(string name, int rollno, double percentage,Streams streams)
        {
            this.name = name;
            this.rollno = rollno;
            this.percentage = percentage;
            this.streams = streams;
        }
        public override string ToString()
        {
            return $"The name is = {name}\n The roll no is ={rollno}\n The percentage is ={percentage}.\n stream is={streams}";
        }
    }
}
