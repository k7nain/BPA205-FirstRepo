using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManagementSystem.Models
{
    public class Teacher : Person
    {
        private string _subject;
        public string Subject
        {
            get { return _subject;}
            set
            {
                if (value.Length != 0)
                {
                    _subject = value;
                }
                else
                {
                    Console.WriteLine("Value can not null");
                }
            }
        }
        private int _experienceYear;
        public int ExperienceYear
        {
            get { return _experienceYear; }
            set
            {
                if (value >= 0)
                {
                    _experienceYear = value;
                }
                else
                {
                    Console.WriteLine("Value can not be negative");
                }
            }
        }

        private bool _isFullTime;
        public bool IsFullTime
        {
            get { return _isFullTime; }
            set { _isFullTime = value; }
        }

        public Teacher(string name, string surname) : base(name, surname)
        {
        }

        public Teacher(string name, string surname, string subject, int experienceYear) : base(name, surname)
        {
            this.Subject = subject;
            this.ExperienceYear = experienceYear;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Subject: {Subject}, Experience Year: {ExperienceYear} ");
        }

        public void CheckFullTime()
        {
            if(IsFullTime == true)
            {
                Console.WriteLine("This teacher works FullTime");
            }
            else
            {
                Console.WriteLine("This teacher works PartTime");
            }
        }

        public void GetExperienceLevel()
        {
            if (ExperienceYear >= 0 && ExperienceYear <= 2)
            {
                Console.WriteLine("Junior Teacher");
            }
            else if (ExperienceYear >= 3 && ExperienceYear <= 5)
            {
                Console.WriteLine("Middle Teacher");
            }
            else if (ExperienceYear >= 6 && ExperienceYear <= 10)
            {
                Console.WriteLine("Senior Teacher");
            }
            else
            {
                Console.WriteLine("Expert Teacher");
            }
        }
    }
}
