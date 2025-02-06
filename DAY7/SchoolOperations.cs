using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7
{
    public partial class SchoolOperations
    {
        private List<Teacher> teachers;
        public SchoolOperations()
        {
            teachers = new List<Teacher>();      
        }
        public void AddTeacher(Teacher teacher)
        {
            if (teachers.Contains(teacher))
            {
                Console.WriteLine("TEACHER ALREADY PRESENT");
                return;
            }
            teachers.Add(teacher);
            Console.WriteLine("TEACHER ADDED");
        }

        public void RemoveTeacher(int teacherId)
        {
            if (teachers == null)
            {
                Console.WriteLine("NO TEACHER ADDED");
                return;
            }
            var teacher = teachers.Where(t => t.GetId() == teacherId).ToList();
            if (teacher.First() == null)
            {
                Console.WriteLine("TEACHER NOT FOUND");
                return;
            }
            teachers.Remove(teacher.First());
            Console.WriteLine("TEACHER REMOVED");
        }
    }

    public partial class SchoolOperations
    {
        public void UpdateSalary(Teacher teacher,float newSalary)
        {
            if (teachers == null)
            {
                Console.WriteLine("NO TEACHER ADDED");
                return;
            }
            var t = teachers.Where(t => t.GetId() == teacher.GetId());
            if (t == null)
            {
                Console.WriteLine("TEACHER NOT FOUND");
                return;
            }
            teacher.SetSalary(newSalary);
            Console.WriteLine("SALARY UPDATED");
        }

        public void DisplayTeachers()
        {
            Console.WriteLine("TEACHERS DISPLAY :");
            foreach (var teacher in teachers)
            {
                teacher.DisplayInfo();
            }
        }
    }
}
