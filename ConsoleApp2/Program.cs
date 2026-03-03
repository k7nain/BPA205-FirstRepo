namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int ID = 1;
            //string name = "Kenan";
            //string surname = "Mursalizade";
            //byte age = 21;
            //char gender = 'M';
            //float height = 1.79f;
            //float weight = 75;
            //bool hasDriverLisense = true;

            Console.WriteLine("IDnizi daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Adiniz daxil edin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadinizi daxil edin: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Yas daxil edin: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Boy daxil edin: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Ceki daxil edin: ");
            float weight = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine(bmi);

        }
    }
}
