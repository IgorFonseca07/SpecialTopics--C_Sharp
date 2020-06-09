using System;
using System.Globalization;

namespace _3_DateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            Console.WriteLine("--------------------------------------");

            DateTime d2 = new DateTime(1994, 05, 26);
            DateTime d3 = new DateTime(1994, 05, 26, 09, 45, 23);
            DateTime d4 = new DateTime(1994, 05, 26, 09, 45, 23, 500);           

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine("--------------------------------------");

            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.Now;
            DateTime d7 = DateTime.UtcNow;

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            Console.WriteLine("--------------------------------------");

            DateTime d8 = DateTime.Parse("1994-05-26");
            DateTime d9 = DateTime.Parse("1994-05-26 09:45:23");

            DateTime d10 = DateTime.Parse("26/05/1994");
            DateTime d11 = DateTime.Parse("26/05/1994 09:45:23");

            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);

            Console.WriteLine("--------------------------------------");

            DateTime d12 = DateTime.ParseExact("1994-26-05", "yyyy-dd-MM", CultureInfo.InvariantCulture);

            DateTime d13 = DateTime.ParseExact("05/26/1994 54:45:09", "MM/dd/yyyy ss:mm:HH", CultureInfo.InvariantCulture);

            Console.WriteLine(d12);
            Console.WriteLine(d13);

        }
    }
}
