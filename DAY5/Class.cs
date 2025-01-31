using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5
{
    public class Class
    {
        string className;
        string section;
        List <Student> students;
        List <Teacher> teachers;

        Class() 
        {
            this.className = className;
            this.section = section; 
            students = new List<Student> ();
            teachers = new List<Teacher>();
        }

        public void addStudentToClass(Student student)
        {
            int rollNo = student.getRollNo();

            foreach (Student s in students)
            {
                if (s.getRollNo() == rollNo)
                {
                    Console.WriteLine("STUDENT ALREADY EXISTS IN THE CLASS");
                    return;
                }
            }
            students.Add(student);
            Console.WriteLine("TEACHER ADDED TO CLASS");
        }

        public void addTeacherToClass(Teacher teacher)
        {
            int teacherId = teacher.getTeacherId();

            foreach (Teacher t in teachers)
            {
                if(t.getTeacherId() == teacherId)
                {
                    Console.WriteLine("TEACHER ALREADY EXISTS IN THE CLASS");
                    return;
                }
            }
            teachers.Add(teacher);
            Console.WriteLine("TEACHER ADDED TO CLASS");
        }
    }
}
