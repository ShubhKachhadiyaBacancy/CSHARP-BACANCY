using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAY7
{
    public sealed class DatabaseConnection
    {
        private List<Teacher> teachersRecord;
        public DatabaseConnection() 
        {
            teachersRecord = new List<Teacher>();
            Console.WriteLine("CONSTRUCTOR : DATABASE CONNECTION");
        }

        public void SaveTeacherRecord(Teacher teacher)
        {
            if (teachersRecord.Contains(teacher))
            {
                Console.WriteLine("TEACHER RECORD ALREADY PRESENT");
                return;
            }
            teachersRecord.Add(teacher);
            Console.WriteLine($"TEACHER RECORD SAVED");
        }
    }
}
