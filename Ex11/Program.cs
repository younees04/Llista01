using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, temp = 0;

            Console.WriteLine("Escriu un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Entra un numero natural");
            }

            else
            {
                int a = 0, b = 1, suma;

                for (int i = 0; i < num; i++)
                {
                    suma = a + b;
                    Console.Write(suma);

                    temp = b;
                    b = suma;
                    a = temp;

                }
            }
        }
    }
}
