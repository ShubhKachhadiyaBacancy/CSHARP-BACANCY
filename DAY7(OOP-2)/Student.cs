using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace DAY7
{
    public class Student : Person,SchoolMember
    {
        private char _grades;
        public Student() 
        {
            Console.WriteLine("CONSTRUCTOR : STUDENT");
        }

        public Student(int id,string name,string role,char grades):base(id,name,role) 
        {
            Console.WriteLine("PARAMETERIZED CONSTRUCTOR : STUDENT");
            this._grades = grades;
            Console.WriteLine("OBJECT CREATED : STUDENT\n");
        }

        public char GetGrades()
        {
            return _grades;
        }

        public void SetGrades(char grades)
        {
            this._grades = grades;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"GRADES : {_grades}\n");
        }

        public string GetRole()
        {
            return PersonGetRole();
        }

        public void PrintSchoolRules()
        {
            Console.WriteLine("RULES FOR STUDENTS : ");
            Console.WriteLine("Ask questions\nRespect and listen to your classmates\n" +
                "Respect and listen to the teacher\nRaise your hand to speak\n" +
                "Be prepared for class\n");
        }
    }
}
