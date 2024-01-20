using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class DelegateFunAnonima2
    {
        delegate string StringOperacao(string s);

        public static void Main1()
        {
            Console.WriteLine("Digite uma Palavra");
            string palavra = Console.ReadLine();

            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("RADAR"));

            if (palavra == inverter(palavra))
            {
                Console.WriteLine($"Parabéns  {palavra} é um palindromo)");

            }
            else
            {

                Console.WriteLine($"{palavra},não é palindromo");
            }
        }
    }
}