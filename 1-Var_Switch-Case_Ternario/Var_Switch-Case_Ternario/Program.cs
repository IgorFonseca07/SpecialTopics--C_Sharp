using System;
using System.Globalization;

namespace Var_Switch_Case_Ternario {
    class Program {
        static void Main(string[] args) {

            var a = 10;
            var b = 15.50;
            var c = "Kelly";

            Console.WriteLine(a + ", " + b.ToString("F2", CultureInfo.InvariantCulture) + ", " + c);

            Console.WriteLine("-------------------------------------------");

            int numberday = int.Parse(Console.ReadLine());
            string day;

            switch(numberday) {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);

            Console.WriteLine("-------------------------------------------");

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double discount = (price < 20.00) ? price * 0.05 : price * 0.10;

            Console.WriteLine(discount.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
