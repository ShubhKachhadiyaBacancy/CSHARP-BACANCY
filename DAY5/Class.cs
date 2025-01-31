using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5
{
    public class Class
    {
        int classId;
        string name;
        string section;
        int teacherId;

        public Class(int classId, string name,string section) 
        {
            this.classId = classId;
            this.name = name;
            this.section = section;
        }

        public int GetClassId()
        {
            return this.classId;
        }

        public void SetClassId(int classId)
        {
            this.classId = classId;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetSection()
        {
            return this.section;
        }

        public void SetSection(string section)
        {
            this.section = section;
        }

        public int GetTeacherId()
        {
            return this.teacherId;
        }

        public void SetTeacherId(int teacherId)
        {
            this.teacherId = teacherId;
        }

    }
}
