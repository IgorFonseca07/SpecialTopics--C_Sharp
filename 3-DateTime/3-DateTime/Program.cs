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

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            DateTime dd = new DateTime(1966, 10, 12, 10, 15, 58, 275);
            
            Console.WriteLine(dd);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1) Date: " + dd.Date);
            Console.WriteLine("2) Day: " + dd.Day);
            Console.WriteLine("3) DayOfWeek: " + dd.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + dd.DayOfYear);
            Console.WriteLine("5) Hour: " + dd.Hour);
            Console.WriteLine("6) Kind: " + dd.Kind);
            Console.WriteLine("7) Millisecond: " + dd.Millisecond);
            Console.WriteLine("8) Minute: " + dd.Minute);
            Console.WriteLine("9) Month: " + dd.Month);
            Console.WriteLine("10) Second: " + dd.Second);
            Console.WriteLine("11) Ticks: " + dd.Ticks);
            Console.WriteLine("12) TimeOfDay: " + dd.TimeOfDay);
            Console.WriteLine("13) Year: " + dd.Year);
            Console.WriteLine("--------------------------------------");

            // Os próximos convertem a variável em string, pode-se jogar o resultado em uma variável string!

            string s1 = dd.ToLongDateString();
            string s2 = dd.ToLongTimeString();
            string s3 = dd.ToShortDateString();
            string s4 = dd.ToShortTimeString();

            string s5 = dd.ToString();

            Console.WriteLine("14) ToLongDateString(): " + dd.ToLongDateString() + " ou " + s1);
            Console.WriteLine("15) ToLongTimeString(): " + dd.ToLongTimeString() + " ou " + s2);
            Console.WriteLine("16) ToShortDateString(): " + dd.ToShortDateString() + " ou " + s3);
            Console.WriteLine("17) ToShortTimeString(): " + dd.ToShortTimeString() + " ou " + s4);
            Console.WriteLine("18) ToString(): " + dd.ToString() + " ou " + s5);
            Console.WriteLine("--------------------------------------");

            string s6 = dd.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = dd.ToString("yyyy-dd-MM HH:mm:ss.fff");

            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();


            // OPERAÇÕES COM DATETIME:


            DateTime dd2 = DateTime.Now;
            DateTime dd22 = new DateTime(2020, 06, 18);
            DateTime dd23 = new DateTime(2020, 06, 25);

            DateTime dd3 = dd2.AddHours(2);
            DateTime dd4 = dd2.AddMinutes(3);
            DateTime dd5 = dd2.AddDays(4);

            TimeSpan t = dd23.Subtract(dd22);

            Console.WriteLine(dd2);
            Console.WriteLine(dd3);
            Console.WriteLine(dd4);
            Console.WriteLine(dd5);
            Console.WriteLine(t);





        }
    }
}
