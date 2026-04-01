using SchoolSystemModel.Models;

namespace SchoolSystemModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Kanan", "Mursalizada", 21);
            Student student2 = new Student("Omar", "Mirzeyev", 20);
            Student student3 = new Student("Turan", "Allahverdiyev", 19);

            student1.GetInfo();
            student2.GetInfo();
            student3.GetInfo();
            Student.GetStatusCount();

        }
    }
}
