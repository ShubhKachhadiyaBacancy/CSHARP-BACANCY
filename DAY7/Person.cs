using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7
{
    public class Person
    {
        private string _name;
        private int _id;
        private string _role;
        public Person()
        {
            Console.WriteLine("CONSTRUCTOR : PERSON");
        }

        public Person(int id,string name, string role) 
        {
            Console.WriteLine("PARAMETERIZED CONSTRUCTOR : PERSON");
            this._id = id;
            this._name = name;
            this._role = role;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            this._id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public string PersonGetRole()
        {
            return _name;
        }

        public void PersonSetRole(string role)
        {
            this._role = role;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"NAME : {_name}\nROLE : {_role}");
        }
    }
}
