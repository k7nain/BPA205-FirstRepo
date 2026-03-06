namespace TaskIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1. (Loji Tapşırıq) Verilmiş ədədin rəqəmlərinin cəmi 10-dursa "bingo", deyilsə cəmini çap edin

            //Console.WriteLine("Ededi daxil edin: ");
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;

            //while (num > 0)
            //{
            //    int t = num % 10;
            //    sum += t;
            //    num /= 10;
            //}

            //if (sum == 10)
            //{
            //    Console.WriteLine("bingo");
            //}
            //else
            //{
            //    Console.WriteLine("Cem: " + sum);
            //}

            //// 2. (Dövr və ardıcıllıq (FizzBuzz)) 1-dən n-ə  qədər ədələri çap edin; 3-ə bölünən "Fizz", 5-ə bölünən "Buzz", hər ikisinə bölünən "FizzBuzz"
            //Console.WriteLine("Ededi daxil edin: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i < n; i++)
            //{
            //    if (i % 3 != 0 && i % 5 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //}

            /*// 3. (String + samitlərin tərsi) Verilmiş stringdəki bütün hərfləri çap edin, amma ik samitlər sonra saitlər olmalıdır
            Console.WriteLine("Sozu daxil edin: ");
            string word = Console.ReadLine();

            char[] sait = ['a', 'e', 'i', 'o', 'u'];
            char[] samit = ['b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'];
            string temp = "";

            for (int i = 0; i < word.Length; i++)
            {
                foreach (char item in samit)
                {
                    if (word[i] == item)
                    {
                        temp = temp + item;
                    }
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                foreach (char item in sait)
                {
                    if (word[i] == item)
                    {
                        temp = temp + item;
                    }
                }
            }
            Console.WriteLine(temp);*/
        }
    }
}
