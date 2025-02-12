//1.Create a class named Course with the following properties:
    //CourseId(int)
    //CourseName(string)
    //Instructor(string)
    //Credits(int)
    //Students(List<string>)

//2.Create a Static List of Courses(Method which returns list of Courses) and populate
//  at least 20 Course with different instructors and students.

//3.Write LINQ Queries(Using Method & Query syntax) to Solve the Following:
    //Get courses with more than 3 credits.
    //Retrieve course names along with their instructors.
    //Use SelectMany to get a list of all students enrolled in courses.
    //Retrieve the total number of courses offered.
    //Find the instructor teaching the most courses.
    //Sort courses by credits, then by name.
    //Retrieve courses grouped by instructor.
    //Find the average number of students per course.
    //Count how many courses each student is enrolled in.
    //Get the course(s) with the highest number of students enrolled.

using DAY9_LINQ_1_;

CourseManagement courseManagement = new CourseManagement();
List<Course> courses = Course.GetCourses();

courseManagement.MethodGetCreditMoreThanFour(courses);
courseManagement.QueryGetCreditMoreThanFour(courses);

courseManagement.MethodGetCourseNameAndInstructors(courses);
courseManagement.QueryGetCourseNameAndInstructors(courses);

courseManagement.MethodGetStudents(courses);
courseManagement.QueryGetStudents(courses);

courseManagement.MethodGetNumberOfCourses(courses);
courseManagement.QueryGetNumberOfCourses(courses);

courseManagement.MethodGetInstructorWithMostCourses(courses);
courseManagement.QueryGetInstructorWithMostCourses(courses);

courseManagement.MethodGetCoursesByCreditsThenByName(courses);
courseManagement.QueryGetCoursesByCreditsThenByName(courses);

courseManagement.MethodGetCoursesGroupedByInstructor(courses);
courseManagement.QueryGetCoursesGroupedByInstructor(courses);

courseManagement.MethodGetAverageStudentsPerCourse(courses);
courseManagement.QueryGetAverageStudentsPerCourse(courses);

courseManagement.MethodGetCourseCountForEachStudent(courses);
courseManagement.QueryGetCourseCountForEachStudent(courses);

courseManagement.MethodGetCoursesWithHighestStudent(courses);
courseManagement.QueryGetCoursesWithHighestStudent(courses);