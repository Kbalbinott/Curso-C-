using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class DelegateFunAnonima
    {
        delegate string StringOperacao(string s);

        public static void Main()
        {
            bool resposta;
            Console.WriteLine("Digite uma Palavra");
            string palavra = Console.ReadLine();
        
            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine("Você tem certeza que é essa palavra");
            string certeza = Console.ReadLine();
            if (certeza == "sim")
            {

                resposta = (palavra == inverter(palavra));

                  
                if (resposta)
                {
                    Console.WriteLine($"parabéns {palavra}  é um palindromo");

                }
                else
                {
                    Console.WriteLine($" {palavra}  não é um palindromo");
                }
            }
            else if (certeza == "nao")
            {
                Console.WriteLine("Executando...");
                Console.WriteLine($"Reinicie o progama.");
            }
        }
    }
}