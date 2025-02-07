using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7
{
    public class SchoolManager : ISchoolOperations
    {   
        private List<Teacher> teachers;
        public SchoolManager() 
        {
            teachers = new List<Teacher>();
            Console.WriteLine("CONSTRUCTOR : SCHOOL MANAGER");
        }
        void ISchoolOperations.AddTeacher(Teacher teacher)
        {
            if (teachers.Contains(teacher))
            {
                Console.WriteLine("TEACHER ALREADY PRESENT");
                return;
            }
            teachers.Add(teacher);
            Console.WriteLine("TEACHER ADDED");
        }
        void ISchoolOperations.RemoveTeacher(int teacherId)
        {
            if(teachers == null)
            {
                Console.WriteLine("NO TEACHER ADDED");
                return;
            }
            var teacher = teachers.Where(t => t.GetId() == teacherId).ToList();
            if(teacher.First() == null)
            {
                Console.WriteLine("TEACHER NOT FOUND");
                return;
            }
            teachers.Remove(teacher.First());
            Console.WriteLine("TEACHER REMOVED");
        }
        void ISchoolOperations.DisplayTeachers()
        {
            Console.WriteLine("TEACHERS DISPLAY :");
            foreach (var teacher in teachers)
            {
                teacher.DisplayInfo();
            }
        }
    }
}
