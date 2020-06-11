using System;

namespace _4_TimeSpan {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(4, 23, 53, 56);
            TimeSpan t5 = new TimeSpan(6, 28, 63, 79);
            TimeSpan t6 = new TimeSpan(9, 15, 35, 48, 335);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.WriteLine("------------------------------------------");

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            //PROPRIEDADES TIMESPAN:

            TimeSpan tt1 = TimeSpan.MaxValue;
            TimeSpan tt2 = TimeSpan.MinValue;
            TimeSpan tt3 = TimeSpan.Zero;

            Console.WriteLine(tt1);
            Console.WriteLine(tt2);
            Console.WriteLine(tt3);

            Console.WriteLine("------------------------------------------");

            TimeSpan ttt = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(ttt);

            Console.WriteLine("1) Days: " + ttt.Days);
            Console.WriteLine("2) Hours: " + ttt.Hours);
            Console.WriteLine("3) Minutes: " + ttt.Minutes);
            Console.WriteLine("4) Seconds: " + ttt.Seconds);
            Console.WriteLine("5) Milliseconds: " + ttt.Milliseconds);
            Console.WriteLine("6) Ticks: " + ttt.Ticks);

            Console.WriteLine("7) TotalDays: " + ttt.TotalDays);
            Console.WriteLine("8) TotalHours: " + ttt.TotalHours);
            Console.WriteLine("9) TotalMinutes: " + ttt.TotalMinutes);
            Console.WriteLine("10) TotalSeconds: " + ttt.TotalSeconds);
            Console.WriteLine("11) TotalMilliseconds: " + ttt.TotalMilliseconds);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            //OPERAÇÕES COM TIMESPAN:

            TimeSpan ttt1 = new TimeSpan(1, 30, 10);
            TimeSpan ttt2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = ttt1.Add(ttt2);
            TimeSpan dif = ttt1.Subtract(ttt2);
            TimeSpan mult = ttt1.Multiply(2.0);
            TimeSpan div = ttt1.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

        }
    }
}
