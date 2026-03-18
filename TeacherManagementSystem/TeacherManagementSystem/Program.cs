using TeacherManagementSystem.Models;

namespace TeacherManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kanan", "Mursalizada");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Surname);
            Console.WriteLine("------------------------");

            Teacher teacher = new Teacher("Omar", "Mirzeyev", "WEB", 11);
            teacher.IsFullTime = true;
            Console.WriteLine(teacher.Name);
            Console.WriteLine(teacher.Surname);
            Console.WriteLine(teacher.Subject);
            Console.WriteLine(teacher.ExperienceYear);

            Console.WriteLine("------------------------");
            teacher.GetInfo();
            teacher.CheckFullTime();
            teacher.GetExperienceLevel();
        }
    }
}
