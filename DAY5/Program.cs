
using DAY5;

StudentManagement studentManagement = new StudentManagement();
studentManagement.AddStudent(7010, "shubh", 21, "kalash Appts");
//studentManagement.AddStudent(7010, "shubh", 21, "kalash Appts" );
//studentManagement.SearchStudent(7010);
//studentManagement.UpdateStudent(7010);
//studentManagement.ViewAllStudents();
//studentManagement.DeleteStudent(7010);
//studentManagement.SearchStudent(7010);

TeacherManagement teacherManagement = new TeacherManagement();
teacherManagement.AddTeacher(1010, "Prachi", 5.5F, new List<string> { ".net", "C#" });
//teacherManagement.SearchTeacher(1010);
//teacherManagement.UpdateTeacher(1010);
//teacherManagement.ViewAllTeachers();
//teacherManagement.DeleteTeacher(1010);
//teacherManagement.SearchTeacher(1010);

ClassManagement classManagement = new ClassManagement();
classManagement.addClass(1,"Saturn","A");
classManagement.AssignTeacherToClass(teacherManagement,1,1010);
classManagement.AssignStudentsToClass(studentManagement,1,7010);
classManagement.ViewAllClasses();
