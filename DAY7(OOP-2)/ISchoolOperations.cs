using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7
{
    public interface ISchoolOperations
    {
        void AddTeacher(Teacher teacher);
        void RemoveTeacher(int teacherID);
        void DisplayTeachers();
    }
}
