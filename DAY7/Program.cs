
using DAY7;

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("TEACHER OBJECTS : ");
Console.WriteLine("-----------------------------------------------");
Teacher teacher1 = new Teacher(101,"JAYDIP","TEACHER",10000.0F,"C#");
Teacher teacher2 = new Teacher(102, "UMESH", "TEACHER", 20000.0F, ".net");

teacher1.DisplayInfo();
teacher2.DisplayInfo();
teacher1.GetRole();
teacher2.PrintSchoolRules();

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("STUDENT OBJECT : ");
Console.WriteLine("-----------------------------------------------");
Student student = new Student(1, "SHUBH", "STUDENT", 'A');
student.DisplayInfo();
student.GetRole();
student.PrintSchoolRules();

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("SCHOOL MANAGER OBJECT : ");
Console.WriteLine("-----------------------------------------------");
SchoolManager schoolManager = new SchoolManager();
((ISchoolOperations)schoolManager).AddTeacher(teacher1);
((ISchoolOperations)schoolManager).AddTeacher(teacher2);
((ISchoolOperations)schoolManager).DisplayTeachers();
((ISchoolOperations)schoolManager).RemoveTeacher(101);
((ISchoolOperations)schoolManager).DisplayTeachers();

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("DATABASE CONNECTION OBJECT : ");
Console.WriteLine("-----------------------------------------------");
DatabaseConnection databaseConnection = new DatabaseConnection();
databaseConnection.SaveTeacherRecord(teacher1);
databaseConnection.SaveTeacherRecord(teacher2);

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("SCHOOL OPERATIONS OBJECT : ");
Console.WriteLine("-----------------------------------------------");
SchoolOperations schoolOperations = new SchoolOperations();
schoolOperations.AddTeacher(teacher1);
schoolOperations.AddTeacher(teacher2);
schoolOperations.UpdateSalary(teacher1,15000.0F);
schoolOperations.UpdateSalary(teacher2, 15000.0F);
schoolOperations.DisplayTeachers();
schoolOperations.RemoveTeacher(101);
schoolOperations.DisplayTeachers();