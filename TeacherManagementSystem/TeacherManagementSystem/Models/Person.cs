using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManagementSystem.Models
{
    public class Person
    {
        private string _name;
        public string Name
        { 
            get { return _name; }
            set { if (value != "")
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Value can not null");
                }
            } 
        }

        string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length != 0)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Value can not null");
                }
            }
        }
        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
    }
}
