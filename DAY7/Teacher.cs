using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7
{
    public class Teacher : Person, SchoolMember 
    {
        private float _salary;
        private string _subject;

        public Teacher()
        {
            Console.WriteLine("CONSTRUCTOR : TEACHER");
        }

        public Teacher(int id,string name,string role,float salary,string subject):base(id,name,role)
        {
            Console.WriteLine("PARAMETERIZED CONSTRUCTOR : TEACHER");
            this._salary = salary;
            this._subject = subject;
            Console.WriteLine("OBJECT CREATED : TEACHER\n");
        }

        public float GetSalary()
        {
            return _salary;
        }

        public void SetSalary(float salary)
        {
            this._salary=salary;
        }

        public override void DisplayInfo() 
        { 
            base.DisplayInfo();
            Console.WriteLine($"SALARY : {_salary}\nSUBJECT : {_subject}\n");
        }

        public void CalculateSalary(int daysWorked)
        {
            Console.WriteLine($"SALARY FOR {daysWorked} : {_salary*daysWorked}");
        }

        public void CalculateSalary(int daysWorked, decimal bonus)
        {
            Console.WriteLine($"SALARY FOR DAYS {daysWorked} AND BONUS {bonus} : " +
                $"{Convert.ToDecimal(_salary * daysWorked)+bonus}");
        }

        public string GetRole()
        {
            return PersonGetRole();
        }

        public void PrintSchoolRules()
        {
            Console.WriteLine("RULES FOR TEACHERS : ");
            Console.WriteLine("Teachers should adhere to formal dress codes\n" +
                "Teachers should speak English on campus\n" +
                "Teachers should avoid drinking or smoking\n" +
                "Teachers should maintain professional decorum\n" +
                "Teachers should avoid negative speech or gossip\n");
        }
    }
}
