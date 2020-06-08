using System;

namespace FunInterString {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper();

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");

        }
    }
}
