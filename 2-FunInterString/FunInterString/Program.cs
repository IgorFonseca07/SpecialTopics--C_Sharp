using System;

namespace FunInterString {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper();   //Todas maiúsculas
            string s2 = original.ToLower();   //Todas minúsculas
            string s3 = original.Trim();      //Corta os espaços em branco no começo ou no final

            int n1 = original.IndexOf("bc");      //Posição onde se encontra trecho citado
            int n2 = original.LastIndexOf("bc");  //Última posição onde se encontra trecho citado

            string s4 = original.Substring(3);    //Irá mostrar o conteúdo da string a partir da posição 3, nesse caso
            string s5 = original.Substring(3, 5); //Irá mostrar o conteúdo da string a partir da posição 3, 5 posições a frente

            string s6 = original.Replace('a', 'x');     //Substituir trecho por outro
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);        //Verificar se string é nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original);   //Verificar se string é nula ou contém espaço(s) em branco

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): -" + n1 + "-");
            Console.WriteLine("LastIndexOf('bc'): -" + n2 + "-");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2 + "-");


        }
    }
}
