using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int any;

            Console.WriteLine("Entra un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            if (any % 4 == 0 && any % 100 != 0 || any % 400 == 0)
                Console.WriteLine("Es un any de traspas");

            else
                Console.WriteLine("No es un any de traspas");
        }
    }
}
