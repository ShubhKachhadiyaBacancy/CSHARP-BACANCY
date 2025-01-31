using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5
{
    public class StudentManagement
    {
        List<Student> students;
        public StudentManagement()
        {
            this.students = new List<Student>();
        }

        public List<Student> getStudents()
        {
            return this.students;
        }

        public void AddStudent(int rollNo, string name, int age, string address)
        {
            foreach (Student s in students)
            {
                if (s.GetRollNo() == rollNo)
                {
                    Console.WriteLine("STUDENT ALREADY EXISTS\n");
                    return;
                }
            }
            students.Add(new Student(rollNo,name,age,address));
            Console.WriteLine("NEW STUDENT ADDED \n");
        }
        
        public void SearchStudent(int rollNo)
        {
            foreach (Student s in students)
            {
                if (s.GetRollNo() == rollNo)
                {
                    Console.WriteLine("STUDENT FOUND");
                    Console.WriteLine($"NAME : {s.GetName()} \nROLLNO : {s.GetRollNo()}" +
                        $"\nAGE : {s.GetAge()} \nADDRESS : {s.GetAddress()} \nCLASS : " +
                        $"{s.GetClassId()}\n");
                    return;
                }
            }
            Console.WriteLine($"STUDENT NOT FOUND\n");
        }
    
        public void ViewAllStudents()
        {
            
            if (students == null)
            {
                Console.WriteLine("NO STUDENT FOUND\n");
                return;
            }
            int count = 1;
            foreach (Student s in students)
            {
                Console.WriteLine($"STUDENT {count} DETAILS : ");
                Console.WriteLine($"NAME : {s.GetName()} \nROLLNO : {s.GetRollNo()}" +
                       $"\nAGE : {s.GetAge()} \nADDRESS : {s.GetAddress()} \nCLASS : " +
                       $"{s.GetClassId()}\n");
                count++;
            }
        }
    
        public void UpdateStudent(int rollNo)
        {
            foreach (Student s in students)
            {
                if (s.GetRollNo() == rollNo)
                {
                    while (true)
                    {
                        Console.WriteLine("1.UPDATE NAME \n2.UPDATE AGE \n3.UPDATE ADDRESS" +
                            "\n4.UPDATE CLASS \n5.EXIT\n");
                        Console.Write("ENTER YOUR CHOICE : ");
                        int updateChoice = Convert.ToInt32(Console.ReadLine());
                        switch (updateChoice)
                        {
                            case 1: 
                                Console.Write("ENTER NEW NAME : ");
                                s.SetName(Console.ReadLine());
                                Console.WriteLine();
                                break;
                            case 2:
                                Console.Write("ENTER NEW AGE : ");
                                s.SetAge(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine();
                                break;
                            case 3:
                                Console.Write("ENTER NEW ADDRESS : ");
                                s.SetAddress(Console.ReadLine());
                                Console.WriteLine();
                                break;
                            case 4:
                                Console.Write("ENTER NEW CLASS : ");
                                s.SetClassId(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine();
                                break;
                            case 5:
                                Console.WriteLine("STUDENT UPDATED");
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
            Console.WriteLine($"STUDENT CANNOT BE UPDATED\n");
        }
    
        public void DeleteStudent(int rollNo)
        {
            var student = students.Where(s => s.GetRollNo() == rollNo);
            if (student.Any())
            {
                students.Remove(student.First());
                Console.WriteLine($"STUDENT DELETED\n");
            }
            else
            {
                Console.WriteLine("STUDENT NOT FOUND\n");
            }
        }
    }
}
