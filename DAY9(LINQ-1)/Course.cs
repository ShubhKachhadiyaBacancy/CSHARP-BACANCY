using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY9_LINQ_1_
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int Credits { get; set; }
        public List<string> Students { get; set; }

        public Course()
        {
            Console.WriteLine("DEFAULT CONSTRUCTOR : COURSE");
            CourseId = 0;
            CourseName = String.Empty;
            Instructor = String.Empty;
            Credits = 0;
            Students = new List<string>();
        }

        public Course(int CourseId, string CourseName, string Instructor, int Credits,
            List<string> Students)
        {
            Console.WriteLine("PARAMETERISED CONSTRUCTOR : COURSE");
            this.CourseId = CourseId;
            this.CourseName = CourseName;
            this.Instructor = Instructor;
            this.Credits = Credits;
            this.Students = Students;
        }

        public static List<Course> GetCourses()
        {
            return new List<Course> {
                new Course(1, "C#", "Shubh", 4, new List<string>{"Rohan", "Drashti","Mox"}),
                new Course(2, "Java", "Ankit", 3, new List<string>{"Aman", "Priya","Vasu"}),
                new Course(3, "Python", "Sneha", 4, new List<string>{ "Arjun", "Isha"}),
                new Course(4, "JavaScript", "Ravi", 3, new List<string>{"Arjun", "Simran"}),
                new Course(5, "Data Structures", "Shubh", 4, new List<string>{"Neha", "Akshay"}),
                new Course(6, "Machine Learning", "Meera", 4, new List<string>{"Pooja", "Nikhil"}),
                new Course(7, "Web Development", "Rahul", 3, new List<string>{"Aarti", "Ramesh"}),
                new Course(8, "AI", "Swati", 4, new List<string>{"Ishaan", "Arjun"}),
                new Course(9, "Cloud Computing", "Anita", 3, new List<string>{ "Arjun", "Rekha"}),
                new Course(10, "Operating Systems", "Ajay", 4, new List<string>{"Vinay", "Seema"}),
                new Course(11, "Networking", "Shivam", 3, new List<string>{"Harsh", "Naina"}),
                new Course(12, "Cyber Security", "Mona", 4, new List<string>{"Raj", "Rohan"}),
                new Course(13, "Blockchain", "Amit", 4, new List<string>{ "Rohan", "Shruti"}),
                new Course(14, "Digital Marketing", "Kavita", 3, new List<string>{ "Rohan", "Ananya"}),
                new Course(15, "Big Data", "Suresh", 4, new List<string>{"Krishna", "Tina"}),
                new Course(16, "Game Development", "Anjali", 3, new List<string>{"Sameer", "Sakshi"}),
                new Course(17, "Database Management", "Nidhi", 4, new List<string>{ "Rohan", "Alisha"}),
                new Course(18, "Statistics", "Rajeev", 3, new List<string>{"Snehal", "Gaurav"}),
                new Course(19, "Human-Computer Interaction", "Geeta", 4, new List<string>{"Pankaj", "Maya"}),
                new Course(20, "Software Engineering", "Arun", 3, new List<string>{"Tanvi", "Sahil"})
            };
        }
    }
}
