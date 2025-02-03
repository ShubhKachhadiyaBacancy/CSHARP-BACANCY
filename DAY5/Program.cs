using DAY5;

StudentManagement studentManagement = new StudentManagement();
try
{
    studentManagement.AddStudent(7010, "shubh", 21, "kalash Appts");
    studentManagement.AddStudent(7011, "mox", 21, "kalash Appts" );
    studentManagement.SearchStudent(7010);
    studentManagement.UpdateStudent(7010);
    studentManagement.ViewAllStudents();
    studentManagement.DeleteStudent(7010);
    studentManagement.SearchStudent(7010);
}
catch (Exception e)
{
    Console.WriteLine("ERROR IN STUDENT");
    Console.WriteLine(e.ToString());
}

TeacherManagement teacherManagement = new TeacherManagement();
try
{
    teacherManagement.AddTeacher(1010, "Prachi", 5.5F, new List<string> { ".net", "C#" });
    //teacherManagement.SearchTeacher(1010);
    //teacherManagement.UpdateTeacher(1010);
    //teacherManagement.ViewAllTeachers();
    //teacherManagement.DeleteTeacher(1010);
    //teacherManagement.SearchTeacher(1010);
}
catch (Exception e)
{
    Console.WriteLine("ERROR IN TEACHER");
    Console.WriteLine(e.ToString());
}

ClassManagement classManagement = new ClassManagement();
try
{
    classManagement.addClass(1,"Saturn","A");
    classManagement.AssignTeacherToClass(teacherManagement,1,1010);
    classManagement.AssignStudentsToClass(studentManagement,1,7010);
    classManagement.ViewAllClasses();
}
catch (Exception e)
{
    Console.WriteLine("ERROR IN CLASS");
    Console.WriteLine(e.ToString());
}