using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool trobat = true;

            Console.WriteLine("Entra un caracter: ");
            char c = Convert.ToChar(Console.ReadLine());

            if (c < 'a' || c > 'z') 
            { 
                trobat = false;
                Console.WriteLine("No es lletra minuscula"); 
            }


            else
            {
                char majuscula = (char)(c - 32);
                Console.WriteLine(majuscula);
            }
        }
    }
}
