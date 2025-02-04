//Class Design & Encapsulation
    //Create a Teacher class with attributes:
        //TeacherID(int)
        //Name(string)
        //Subject(string)
        //Salary(private decimal)
    //Implement Encapsulation:
        //Restrict direct access to Salary (private).
        //Provide methods: GetSalary()(getter) and SetSalary(decimal salary) (setter, ensuring salary is non - negative).
    //Implement:
        //Parameterized Constructor to initialize teacher details.
        //Destructor to print a message when a teacher leaves.

//Tasks to Implement:
    //Create Teachers & Students:
        //Add 3 teachers and 5 students.
        //Ensure encapsulation restricts modifying Salary directly.

using DAY6;

Teacher teacher1  = new Teacher(1,"Jaydip","C# OOP");
teacher1.SetSalary(20000.00M);
Console.WriteLine($"TEACHER ID : {teacher1.TeacherId}\nTEACHER NAME : {teacher1.Name}\n" +
    $"TEACHER SUBJECT : {teacher1.Subject}\nTEACHER SALARY : {teacher1.GetSalary()}\n");

Teacher teacher2  = new Teacher(2,"Umesh","C# Basics");
teacher2.SetSalary(10000.00M);
Console.WriteLine($"TEACHER ID : {teacher2.TeacherId}\nTEACHER NAME : {teacher2.Name}\n" +
    $"TEACHER SUBJECT : {teacher2.Subject}\nTEACHER SALARY : {teacher2.GetSalary()}\n");

Teacher teacher3 = new Teacher(3, "Nishita", "C# QUIZ");
teacher3.SetSalary(-10000M);
//teacher3.salary = 5000M; //ERROR BCZ OF ENCAPSULATION
Console.WriteLine($"TEACHER ID : {teacher3.TeacherId}\nTEACHER NAME : {teacher3.Name}\n" +
    $"TEACHER SUBJECT : {teacher3.Subject}\nTEACHER SALARY : {teacher3.GetSalary()}\n");

Student student1 = new Student();
student1.StudentId = 7010;
student1.StudentName = "Shubh";

Student student2 = new Student();
student1.StudentId = 7011;
student1.StudentName = "Rohan";

Student student3 = new Student();
student1.StudentId = 7012;
student1.StudentName = "Drashti";

Student student4 = new Student();
student1.StudentId = 7013;
student1.StudentName = "Moxshang";

Student student5 = new Student();
student1.StudentId = 7014;
student1.StudentName = "Ishika";