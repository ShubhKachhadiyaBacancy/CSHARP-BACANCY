using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5
{
    public class TeacherManagement
    {
        List<Teacher> teachers;

        public TeacherManagement()
        {
            teachers = new List<Teacher>();
        }

        public List<Teacher> GetTeachers()
        {
            return teachers;
        }

        public void AddTeacher(int teacherId,string name, float experience,List<string>subjects)
        {
            foreach (Teacher t in teachers)
            {
                if (t.GetTeacherId() == teacherId)
                {
                    Console.WriteLine("TEACHER ALREADY EXISTS\n");
                    return;
                }
            }
            teachers.Add(new Teacher(teacherId,name, experience,subjects));
            Console.WriteLine("NEW TEACHER ADDED \n");
        }

        public void ViewAllTeachers()
        {
            if (teachers == null)
            {
                Console.WriteLine("NO TEACHER FOUND\n");
                return;
            }
            int count = 1;

            foreach (Teacher t in teachers)
            {
                List<string> subjects = t.GetSubjects();
                string strSubjects="";
                foreach (string subject in subjects) {
                    strSubjects += subject + ", ";
                }
                Console.WriteLine($"TEACHER {count} DETAILS : ");
                Console.WriteLine($"NAME : {t.GetName()} \nID : {t.GetTeacherId()}" +
                       $"\nEXPERIENCE : {t.GetExperience()} \nSUBJECTS : " +
                       $"{strSubjects}\n");
                count++;
            }
        }

        public void SearchTeacher(int teacherId)
        {
            foreach (Teacher t in teachers)
            {
                if (t.GetTeacherId() == teacherId)
                {
                    List<string> subjects = t.GetSubjects();
                    string strSubjects = "";
                    foreach (string subject in subjects)
                    {
                        strSubjects += subject + ", ";
                    }
                    Console.WriteLine("TEACHER FOUND");
                    Console.WriteLine($"NAME : {t.GetName()} \nID : {t.GetTeacherId()}" +
                       $"\nEXPERIENCE : {t.GetExperience()} \nSUBJECTS : " +
                       $"{strSubjects}\n");
                    return;
                }
            }
            Console.WriteLine($"TEACHER NOT FOUND\n");
        }

        public void UpdateTeacher(int teacherId)
        {
            foreach (Teacher t in teachers)
            {
                if (t.GetTeacherId() == teacherId)
                {
                    while (true)
                    {
                        Console.WriteLine("1.UPDATE NAME \n2.UPDATE EXPERIENCE \n3.UPDATE SUBJECT" +
                            "\n4.EXIT\n");
                        Console.Write("ENTER YOUR CHOICE : ");
                        int updateChoice = Convert.ToInt32(Console.ReadLine());
                        switch (updateChoice)
                        {
                            case 1:
                                Console.Write("ENTER NEW NAME : ");
                                t.SetName(Console.ReadLine());
                                Console.WriteLine();
                                break;
                            case 2:
                                Console.Write("ENTER NEW EXPERIENCE : ");
                                t.SetExperience(float.Parse(Console.ReadLine()));
                                Console.WriteLine();
                                break;
                            case 3:
                                Console.Write("ENTER NEW SUBJECT : ");
                                t.SetSubject(Console.ReadLine());
                                Console.WriteLine();
                                break;
                            case 4:
                                Console.WriteLine("TEACHER UPDATED");
                                Console.WriteLine();
                                return;
                            default:
                                Console.WriteLine("INVALID INPUT");
                                Console.WriteLine();
                                break;
                        }
                    }
                }
            }
            Console.WriteLine($"TEACHER CANNOT BE UPDATED\n");
        }

        public void DeleteTeacher(int teacherId)
        {
            var teacher = teachers.Where(t => t.GetTeacherId() == teacherId);
            if (teacher.Any())
            {
                teachers.Remove(teacher.First());
                Console.WriteLine($"TEACHER DELETED\n");
            }
            else
            {
                Console.WriteLine("TEACHER NOT FOUND\n");
            }
        }
    }
}
