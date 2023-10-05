using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Escribe un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            for (int i = 1; i <= num; i++)
            {
                suma += i;

                for (int j = 1; j <= i; j++)
                {
                    if (j == 1)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(" + " + j);
                    }
                }

                Console.WriteLine(" = " + suma);
            }

        }
    }
}
