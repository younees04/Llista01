using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Escriu un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++) 
            {
                Console.WriteLine();
                Console.WriteLine("Taula de multiplicar numero " + i);
                Console.WriteLine();
                for (int j = 0; j <= 10; j++)
                {
                    int resultat = (i * j);
                    Console.WriteLine($"{i} * {j} = {resultat}");
                }
            }
        }
    }
}
