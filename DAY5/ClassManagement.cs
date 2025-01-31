using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5
{
    public class ClassManagement
    {
        List<Class> classes;
        public ClassManagement() { 
            classes = new List<Class>();
        }

        public void addClass(int classId,string name,string section)
        {
            foreach (Class c in classes)
            {
                if (c.GetClassId() == classId)
                {
                    Console.WriteLine("CLASS ALREADY EXISTS\n");
                    return;
                }
            }
            classes.Add(new Class(classId, name, section));
            Console.WriteLine("NEW CLASS ADDED \n");
        }

        public void ViewAllClasses()
        {
            if (classes == null)
            {
                Console.WriteLine("NO CLASSES FOUND\n");
                return;
            }
            int count = 1;

            foreach (Class c in classes)
            {
                Console.WriteLine($"CLASSES {count} DETAILS : ");
                Console.WriteLine($"NAME : {c.GetName()} \nSECTION : {c.GetSection()}" +
                       $"\nTEACHER : {c.GetTeacherId()}");
                count++;
            }
        }

        public void AssignStudentsToClass(StudentManagement studentManagement,int classId,int rollNo)
        {
            List<Student> students = studentManagement.getStudents();
            var student = students.Where(s => s.GetRollNo() == rollNo);
            var cl = classes.Where(c => c.GetClassId() == classId);

            if (student.Any() && cl.Any())
            {
                student.First().SetClassId(classId);
                return;
            }
            Console.WriteLine("CLASS CANNOT BE ASSIGNED TO STUDENT\n");
        }

        public void AssignTeacherToClass(TeacherManagement teacherManagement, int classId, int teacherId)
        {
            List<Teacher> teachers = teacherManagement.GetTeachers();
            var teacher = teachers.Where(t => t.GetTeacherId() == teacherId);
            var cl = classes.Where(c => c.GetClassId() == classId);

            if (teacher.Any() && cl.Any())
            {
                cl.First().SetTeacherId(teacherId);
                return;
            }
            Console.WriteLine("CLASS CANNOT BE ASSIGNED TO STUDENT");
        }
    }
}
