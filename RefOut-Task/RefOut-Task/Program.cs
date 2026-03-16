namespace RefOut_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////2.1 Verilən iki ədədin yerini dəyişdirən metod yazın.(üçüncü dəyişən yaradılmamalıdır)
            //Console.WriteLine("1-ci ededi daxil edin: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("2-ci ededi daxil edin: ");
            //int b = int.Parse(Console.ReadLine());

            //Swap(ref a, ref b);
            //Console.WriteLine($"a: {a}, b: {b}");



            //2.2 Verilmiş radius üçün dairənin sahəsini və uzunlugu out parametr vasitəsilə qaytaran metod yazın.
            double field;
            double length;


            FieldAndLength(out field, out length, out int r);
            Console.WriteLine($"Field: {field}");
            Console.WriteLine($"Length: {length}");


        }

        ////2.1 Verilən iki ədədin yerini dəyişdirən metod yazın.(üçüncü dəyişən yaradılmamalıdır)
        //public static void Swap(ref int a, ref int b)
        //{
        //    a += b;
        //    b = a - b;
        //    a -= b;
        //}

        public static void FieldAndLength(out double field, out double length, out int r)
        {
            Console.WriteLine("Radiusu daxil edin: ");
            r = int.Parse(Console.ReadLine());

            length = 2 * Math.PI * r;
            field = Math.PI * Math.Pow(r, 2);

        }
    }
}
