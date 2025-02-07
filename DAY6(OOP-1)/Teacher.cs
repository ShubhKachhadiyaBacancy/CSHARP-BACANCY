using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        private decimal salary;

        public Teacher()
        {
            Console.WriteLine("CONSTRUCTOR : TEACHER");
        }

        public Teacher(int teacherId,string name,string subject)
        {
            Console.WriteLine("PARAMETERIZED CONSTRUCTOR : TEACHER");
            this.TeacherId = teacherId;
            this.Name = name;
            this.Subject = subject;
        }

        ~Teacher()
        {
            Console.WriteLine("DESCTRUCTOR : TEACHER");
        }

        public void SetSalary(decimal salary)
        {
            if (salary < 0)
            {
                Console.WriteLine("SALARY CANNOT BE NEGATIVE");
            }
            else
            {
                this.salary = salary;
            }
        }

        public decimal GetSalary() 
        {
            return this.salary;
        }
    }
}
