using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAY9_LINQ_1_
{
    public class CourseManagement
    {
        public CourseManagement() 
        {
            Console.WriteLine("DEFAULT CONSTRUCTOR : COURSE MANAGEMENT");
        }

        public void Display(List<Course> courses)
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"ID : {course.CourseId}\nNAME : {course.CourseName}\n" +
                    $"INSTRUCTOR : {course.Instructor}\nCREDIT : {course.Credits}");
                Console.WriteLine($"STUDENTS : {string.Join(", ", course.Students)}\n");
            }
        }

        //Get courses with more than 3 credits.
        public void MethodGetCreditMoreThanFour(List<Course> courses)
        {
            List<Course> credits = courses.Where(course => course.Credits > 3).ToList();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("COURSES WITH MORE THAN 3 CREDITS(METHOD) : ");
            Console.WriteLine("-------------------------------------------");
            Display(credits);
        }
        public void QueryGetCreditMoreThanFour(List<Course> courses)
        {
            List<Course> credits = (from course in courses 
                                    where course.Credits > 3 
                                    select course).ToList();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("COURSES WITH MORE THAN 3 CREDITS(QUERY) : ");
            Console.WriteLine("------------------------------------------");
            Display(credits);
        }

        //Retrieve course names along with their instructors.
        public void MethodGetCourseNameAndInstructors(List<Course> c)
        {
            var courses = c.Select(course => (course.CourseName,course.Instructor));
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("COURSES NAME ALONG WITH THEIR INSTRUCTORS(METHOD ) : ");
            Console.WriteLine("-----------------------------------------------------");
            foreach (var course in courses)
            {
                Console.WriteLine($"NAME : {course.CourseName}\nINSTRUCTOR : " +
                    $"{course.Instructor}");
            }
        }
        public void QueryGetCourseNameAndInstructors(List<Course> c)
        {
            var courses = from course in c 
                          select (course.CourseName,course.Instructor);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("COURSES NAME ALONG WITH THEIR INSTRUCTORS(QUERY) : ");
            Console.WriteLine("---------------------------------------------------");
            foreach (var course in courses)
            {
                Console.WriteLine($"NAME : {course.CourseName}\nINSTRUCTOR : " +
                    $"{course.Instructor}");
            }
        }

        //Use SelectMany to get a list of all students enrolled in courses.
        public void MethodGetStudents(List<Course> courses)
        {
            var students = courses.SelectMany(c => c.Students).Distinct();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("STUDENT NAMES ENROLLED IN COURSES(METHOD) : ");
            Console.WriteLine("-------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine($"STUDENT NAME : {student}");
            }
        }
        public void QueryGetStudents(List<Course> courses)
        {
            var students = (from course in courses 
                            from student in course.Students 
                            select student).Distinct();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("STUDENT NAMES ENROLLED IN COURSES(QUERY) : ");
            Console.WriteLine("-------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine($"STUDENT NAME : {student}");
            }
        }

        //Retrieve the total number of courses offered.
        public void MethodGetNumberOfCourses(List<Course> courses)
        {
            var count = courses.Distinct().Count();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("NUMBER OF COURSES OFFERED(METHOD) : ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"COUNT : {count}");
        }
        public void QueryGetNumberOfCourses(List<Course> courses)
        {
            var count = (from course in courses 
                         select course).Distinct().Count();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("NUMBER OF COURSES OFFERED(METHOD) : ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"COUNT : {count}");
        }

        //Find the instructor teaching the most courses.
        public void MethodGetInstructorWithMostCourses(List<Course> courses)
        {
            var instructor = courses.GroupBy(course => course.Instructor).OrderByDescending(i => i.Count()).First();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("INSTRUCTOR WITH MOST COURSES(METHOD) : ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"NAME : {instructor.Key}\nCOUNT OF COURSES: {instructor.Count()}");
        }
        public void QueryGetInstructorWithMostCourses(List<Course> courses)
        {
            var instructor = (from course in courses 
                             group course by course.Instructor into grouped
                             orderby grouped.Count() descending
                             select grouped).First();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("INSTRUCTOR WITH MOST COURSES(METHOD) : ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"NAME : {instructor.Key}\nCOUNT OF COURSES: {instructor.Count()}");
        }

        //Sort courses by credits, then by name.
        public void MethodGetCoursesByCreditsThenByName(List<Course> c)
        {
            List<Course> courses = c.OrderBy(course => course.Credits).ThenBy(c => c.CourseName).ToList();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("SORT COURSES BY CREDITS THEN BY NAME(METHOD) : ");
            Console.WriteLine("-----------------------------------------------");
            Display(courses);
        }
        public void QueryGetCoursesByCreditsThenByName(List<Course> c)
        {
            List<Course> courses = (from course in c 
                                   orderby course.Credits,course.CourseName
                                   select course).ToList();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("SORT COURSES BY CREDITS THEN BY NAME(QUERY) : ");
            Console.WriteLine("----------------------------------------------");
            Display(courses);
        }

        //Retrieve courses grouped by instructor.
        public void MethodGetCoursesGroupedByInstructor(List<Course> c)
        {
            var courses = c.GroupBy(course => course.Instructor)
                          .Select(g => new {
                              instructor = g.Key,
                              course = g.Select(cn => cn.CourseName)
                          });
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("COURSES GROUPED BY INSTRUCTOR(METHOD) : ");
            Console.WriteLine("----------------------------------------");
            foreach (var course in courses)
            {
                Console.WriteLine($"INSTRUCTOR : {course.instructor}\nCOURSES : " +
                    $"{string.Join(", ",course.course)}\n");
            }
        }
        public void QueryGetCoursesGroupedByInstructor(List<Course> c)
        {
            var courses = from course in c
                          group course by course.Instructor into grouped
                          select new
                          {
                              instructor = grouped.Key,
                              course = grouped.Select(cn => cn.CourseName)
                          };
                          
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("COURSES GROUPED BY INSTRUCTOR(QUERY) : ");
            Console.WriteLine("---------------------------------------");
            foreach (var course in courses)
            {
                Console.WriteLine($"INSTRUCTOR : {course.instructor}\nCOURSES : " +
                    $"{string.Join(", ", course.course)}\n");
            }
        }

        //Find the average number of students per course.
        public void MethodGetAverageStudentsPerCourse(List<Course> courses) 
        {
            var average = courses.GroupBy(course => course.CourseName)
                                 .Select(g => new
                                 {
                                     course = g.Key,
                                     totalCount = g.Sum(c => c.Students.Count())
                                 }).Select(c => c.totalCount).Average();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("AVERAGE STUDENTS PER COURSE(METHOD) : ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"COURSE AVERAGE : {average}");
        }
        public void QueryGetAverageStudentsPerCourse(List<Course> courses)
        {
            var average = (from course in courses
                           group course by course.CourseName into courseGroup
                           select courseGroup.Sum(c => c.Students.Count()))
                           .Average();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("AVERAGE STUDENTS PER COURSE(QUERY) : ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"COURSE AVERAGE : {average}");
        }

        //Count how many courses each student is enrolled in.
        public void MethodGetCourseCountForEachStudent(List<Course> courses)
        {
            var students = courses
            .SelectMany(course => course.Students)
            .GroupBy(student => student)
            .Select(studentGroup => new
            {
                studentName = studentGroup.Key,
                courseCount = studentGroup.Count()
            });

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("COUNT OF COURSE FOR EACH STUDENT(METHOD) : ");
            Console.WriteLine("-------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine($"STUDENT NAME : {student.studentName}\n" +
                    $"COURSES : {student.courseCount}");
            }
        }
        public void QueryGetCourseCountForEachStudent(List<Course> courses)
        {
            var students =
            from course in courses
            from student in course.Students
            group student by student into studentGroup
            select new
            {
                studentName = studentGroup.Key,
                courseCount = studentGroup.Count()
            };

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("COUNT OF COURSE FOR EACH STUDENT(QUERY) : ");
            Console.WriteLine("------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine($"STUDENT NAME : {student.studentName}\n" +
                    $"COURSES : {student.courseCount}");
            }
        }

        //Get the course with the highest number of students enrolled.
        public void MethodGetCoursesWithHighestStudent(List<Course> courses)
        {
            var course = courses.GroupBy(course => course.CourseName)
                                 .Select(g => new
                                 {
                                     courseName = g.Key,
                                     totalCount = g.Sum(c => c.Students.Count())
                                 })
                                 .OrderByDescending(o => o.totalCount).ToList();

            int i;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("COURSE(S) WITH HIGHEST STUDENT(METHOD) : ");
            Console.WriteLine("------------------------------------------");
            for (i = 0;i < course.Count()-1;i++)
            {
                if (course[i].totalCount == course[i + 1].totalCount)
                {
                    Console.WriteLine($"COURSE NAME : {course[i].courseName}\n" +
                    $"STUDENT COUNT : {course[i].totalCount}");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"COURSE NAME : {course[i].courseName}\n" +
                   $"STUDENT COUNT : {course[i].totalCount}");
        }
        public void QueryGetCoursesWithHighestStudent(List<Course> courses)
        {
            var c = (from course in courses
                     group course by course.CourseName into grouped
                     select new
                     {
                         courseName = grouped.Key,
                         totalCount = grouped.Sum(c => c.Students.Count)
                     })
                    .OrderByDescending(o => o.totalCount)
                    .ToList();
                    
            int i;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("COURSE(S) WITH HIGHEST STUDENT(QUERY) : ");
            Console.WriteLine("------------------------------------------");
            for (i = 0; i < c.Count() - 1; i++)
            {
                if (c[i].totalCount == c[i + 1].totalCount)
                {
                    Console.WriteLine($"COURSE NAME : {c[i].courseName}\n" +
                    $"STUDENT COUNT : {c[i].totalCount}");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"COURSE NAME : {c[i].courseName}\n" +
                   $"STUDENT COUNT : {c[i].totalCount}");
        }
    }
}