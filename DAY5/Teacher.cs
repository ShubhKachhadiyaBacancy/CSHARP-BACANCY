using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5
{
    public class Teacher
    {
        string name;
        int experience;
        int teacherId;
        List<string> subjects;

        public int getTeacherId()
        {
           return this.teacherId;
        }
    }
}
