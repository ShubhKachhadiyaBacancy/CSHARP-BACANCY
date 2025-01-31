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
        float experience;
        int teacherId;
        List<string> subjects;

        public Teacher(int teacherId,string name,float experience,List<string> subjects)
        {
            this.name = name;
            this.experience = experience;
            this.teacherId = teacherId;
            this.subjects = subjects;
        }

        public int GetTeacherId()
        {
           return this.teacherId;
        }

        public void SetTeacherId(int teacherId)
        {
            this.teacherId = teacherId;
        }

        public float GetExperience()
        {
            return this.experience;
        }

        public void SetExperience(float experience)
        {
            this.experience = experience;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSubject(string subject)
        {
            if (subjects.Contains(subject))
            {
                Console.WriteLine($"{subject.ToUpper()} ALREADY EXISTS");
                return;
            }
            this.subjects.Add(subject);
            Console.WriteLine($"{subject.ToUpper()} ADDED");
        }

        public List<string> GetSubjects()
        {
            return this.subjects;
        }
    }
}
