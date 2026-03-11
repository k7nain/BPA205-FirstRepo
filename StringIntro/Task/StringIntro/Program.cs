namespace StringIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1. Capitalize() — Hər sözün ilk hərfini böyüdür.
            //Console.WriteLine("Cumleni daxil edin: ");
            //string sentence = Console.ReadLine();
            //string temp = "";
            //string result = "";

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] != ' ')
            //    {
            //        temp += sentence[i];
            //    }
            //    else
            //    {
            //        if (temp.Length > 0)
            //        {
            //            temp = char.ToUpper(temp[0]) + temp.Substring(1);
            //            result = result + temp + " ";
            //            temp = "";
            //        }
            //    }
            //}

            //if (temp.Length > 0)
            //{
            //    temp = char.ToUpper(temp[0]) + temp.Substring(1);
            //    result = result + temp;
            //}
            //Console.WriteLine("Netice: " + result);




            //// 2. Contains() — İki string verilir, ikinci string birincinin içərisində varmı yoxlayır.
            //Console.WriteLine("1-ci stringi daxil edin: ");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("2-ci stringi daxil edin: ");
            //string s2 = Console.ReadLine();

            //bool tapildi = false;

            //for (int i = 0; i <= s1.Length - s2.Length; i++)
            //{
            //    bool eyni = true;

            //    for (int j = 0; j < s2.Length; j++)
            //    {
            //        if (s1[i + j] != s2[j])
            //        {
            //            eyni = false;
            //            break;
            //        }
            //    }
            //    if (eyni)
            //    {
            //        tapildi = true;
            //        break;
            //    }
            //}

            //if (tapildi)
            //    Console.WriteLine("Var");
            //else
            //    Console.WriteLine("Yoxdur");



            //// 3. Length — Stringin neçə simvoldan ibarət olduğunu qaytarır.
            //Console.WriteLine("Stringi daxil edin: ");
            //string str = Console.ReadLine();

            //int count = 0;

            //foreach (var item in str)
            //{
            //    count++;
            //}
            //Console.WriteLine(count);




            //// 4. EndsWith() — Stringin verilən söz və ya simvol ilə bitib-bitmədiyini yoxlayır.
            //Console.WriteLine("1-ci stringi daxil edin: ");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("2-ci stringi daxil edin: ");
            //string s2 = Console.ReadLine();

            //bool tapildi = false;

            //for (int i = 0; i <= s1.Length - s2.Length; i++)
            //{
            //    bool eyni = true;

            //    for (int j = 0; j < s2.Length; j++)
            //    {
            //        if (s1[i + j] != s2[j])
            //        {
            //            eyni = false;
            //            break;
            //        }
            //    }
            //    if (eyni)
            //    {
            //        tapildi = true;
            //        break;
            //    }

            //}

            //if (s1[0] == s2[0] && s1[s1.Length - 1] != s2[s2.Length - 1])
            //{
            //    tapildi = false;
            //}

            //if (tapildi)
            //    Console.WriteLine("Var");
            //else
            //    Console.WriteLine("Yoxdur");



            //// 5. StartsWith() — Stringin verilən söz və ya simvol ilə başlayıb-başlamadığını yoxlayır.
            //Console.WriteLine("1-ci stringi daxil edin: ");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("2-ci stringi daxil edin: ");
            //string s2 = Console.ReadLine();

            //bool tapildi = false;

            //for (int i = 0; i <= s1.Length - s2.Length; i++)
            //{
            //    bool eyni = true;

            //    for (int j = 0; j < s2.Length; j++)
            //    {
            //        if (s1[i + j] != s2[j])
            //        {
            //            eyni = false;
            //            break;
            //        }
            //    }
            //    if (eyni)
            //    {
            //        tapildi = true;
            //        break;
            //    }

            //}

            //if (s1[0] != s2[0] && s1[s1.Length - 1] == s2[s2.Length - 1])
            //{
            //    tapildi = false;
            //}

            //if (tapildi)
            //    Console.WriteLine("Var");
            //else
            //    Console.WriteLine("Yoxdur");



            // 6. Replace() — Stringdəki müəyyən söz və ya simvolu başqa söz və ya simvol ilə əvəz edir.
            Console.WriteLine("Stringi daxil edin: ");
            string str = Console.ReadLine();
            Console.WriteLine("Evezlenecek daxil edin: ");
            char s = char.Parse(Console.ReadLine());
            Console.WriteLine("Evezleyen daxil edin: ");
            char r = char.Parse(Console.ReadLine());

            string result = "";

            foreach (var item in str)
            {
                if (item == s)
                {
                    result += r;
                }
                else
                {
                    result += item;
                }
            }
            Console.WriteLine(result);




            //// 7. Substring() — Stringdən müəyyən indexdən başlayaraq istənilən uzunluqda hissə götürür.
            //Console.WriteLine("Stringi daxil edin: ");
            //string str = Console.ReadLine();

            //Console.WriteLine("Indexi daxil edin: ");
            //int index = int.Parse(Console.ReadLine());

            //string temp = "";

            //for (int i = index; i < str.Length; i++)
            //{
            //    temp = temp + str[i];
            //}

            //Console.WriteLine(temp);
        }
    }
}
