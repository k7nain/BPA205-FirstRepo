namespace SchoolSystemModel.Models
{
    public class Student
    {
        public static int Id { get; set; } = 1;
        public string Name { get; set; }
        public string  Surname { get; set; }
        public int Age { get; set; }

        public const string schoolName = "Code Academy";

        public static int studentCount;

        public readonly string studentCode;
        public int studentId;

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            studentId = Id++;
            studentCount++;
            studentCode = new string(studentId.ToString()[0], 6);
        }

        public static void GetStatusCount()
        {
            Console.WriteLine($"Student count: {studentCount}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Id: {studentId}, Name: {Name}, Surname: {Surname}, Age: {Age}, StudentCode: {studentCode}, School Name: {schoolName} ");
        }


    }
}
