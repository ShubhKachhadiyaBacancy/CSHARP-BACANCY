using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5
{
    public class Student
    {
        string name;
        int age;
        int rollNo;
        string address;
        Class studentClass;
        Student(int rollNo, string name, int age,string address,Class studentClass)
        {
            this.name = name;
            this.age = age;
            this.rollNo = rollNo;
            this.address = address;
            this.studentClass = studentClass;
        }

        public int getRollNo()
        {
            return this.rollNo;
        }

        public void update(string name, int age, string address, Class studentClass)
        {

        }
    }
}
