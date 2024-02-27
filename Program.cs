
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            string a = Console.ReadLine();

            Console.Write("Digite o valor de B: ");
            string b = Console.ReadLine();

            string b1 = a;

            a = b;

            b = b1;

            Console.WriteLine("O valor de B: " + a);
            Console.Write(" Valor de A: " + b);

            Console.ReadKey();

        }
    }
}
