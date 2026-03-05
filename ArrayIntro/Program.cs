namespace ArrayIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1. Ədədlərdən ibarət array-in içərisində ən böyük element tapan program
            //int[] nums = [-3, 25, -18, 7, 0, -9, 41, -22, 5, 13];
            //int max = nums[0];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //}

            //Console.WriteLine("Max: " + max);


            //// 2. Söz və hərf verilib. Sözün içində həmin hərfin olub-olmadığını tapan program
            //Console.WriteLine("Sozu daxil edin: ");
            //string word = Console.ReadLine();

            //Console.WriteLine("Herfi daxil edin: ");
            //char letter = char.Parse(Console.ReadLine());

            //int check = 0;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //    {
            //        Console.WriteLine(letter + " herfi " + word + " icinde var");
            //        check = 0;
            //        break;
            //    }
            //    else
            //    {
            //        check = check + 1;
            //    }
            //}
            //if (check != 0) 
            //{
            //    Console.WriteLine(letter + " herfi " + word + " icinde yoxdur");
            //}



            //// 3. Verilmiş mətnin .az domainli (kontakt.az) sayt adı olub-olmadığını tapan program
            //Console.WriteLine("Sozu daxil edin: ");
            //string word = Console.ReadLine();
            //bool check = false;

            //for (int i = 0; i < word.Length - 2; i++)
            //{
            //    if (word[i] == '.' && word[i + 1] == 'a' && word[i + 2] == 'z')
            //    {
            //        check = true;
            //        break;
            //    }
            //}
            //if (check == false)
            //    Console.WriteLine("Yoxdur");
            //else
            //    Console.WriteLine("Var");



            // 4. Verilmiş sözün cümlədə işlənib işlənmədiyi tapan program
            //Console.WriteLine("Cumleni daxil edin: ");
            //string sentence = Console.ReadLine();

            //Console.WriteLine("Sozu daxil edin: ");
            //string word = Console.ReadLine();
            //bool check = false;
            //string temp = "";

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] != ' ')
            //    {
            //        temp = temp + sentence[i];
            //    }
            //    else
            //    {
            //        if (temp == word)
            //        {
            //            check = true;
            //            break;
            //        }
            //        temp = "";
            //    }
            //}
            //if (temp == word)
            //{
            //    check = true;
            //}

            //if (check)
            //    Console.WriteLine("Var");
            //else
            //    Console.WriteLine("Yoxdur");

            //// 5. Verilmiş cümlədə hər sözün ilk hərfini böyük edən program
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

            // 7. Verilmiş stringin içindəki bütün boşluqlara %20 ilə əvəz edən program
            Console.WriteLine("Cumleni daxil edin: ");
            string sentence = Console.ReadLine();
            string temp = "";
            string result = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    temp += sentence[i];
                }
                else
                {
                    if (temp.Length > 0)
                    {
                        result = result + temp + "%20";
                        temp = "";
                    }
                }
            }
            if (temp.Length > 0)
            {
                result = result + temp;
            }
            Console.WriteLine("Netice: " + result);
        }
    }
}
