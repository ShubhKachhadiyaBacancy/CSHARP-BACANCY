using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public Student()
        {
            Console.WriteLine("CONSTRUCTOR : STUDENT");
        }

        ~Student() 
        {
        Console.WriteLine("DESTRUCTOR : STUDENT");
        }
    }
}
