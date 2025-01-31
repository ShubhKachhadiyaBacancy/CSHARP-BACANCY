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
        int classId;
        public Student(int rollNo, string name, int age,string address)
        {
            this.name = name;
            this.age = age;
            this.rollNo = rollNo;
            this.address = address;
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetRollNo()
        {
            return this.rollNo;
        }

        public void SetRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }

        public String GetAddress()
        {
            return address;
        }

        public void SetAddress(String address)
        {
            this.address = address;
        }

        public int GetClassId()
        {
            return classId;
        }
        
        public void SetClassId(int classId)
        {
            this.classId = classId;
        }
    }
}
