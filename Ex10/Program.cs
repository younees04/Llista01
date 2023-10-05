using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, residu=-1;
            bool trobat = false;

            Console.WriteLine("Escriu el valor A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriu el valor B: ");
            b = Convert.ToInt32(Console.ReadLine());

                while (residu != 0 && !trobat)
                {
                    residu = a % b;

                    if (residu == 0) trobat = true;

                    else
                    {
                        a = b;
                        b = residu;
                    }
                }
            
            if (trobat)
                Console.WriteLine("El MCD de a i b és: " + b);

            else Console.WriteLine("No s'ha trobat el MCD");
        }
    }
}
