using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hores, min, seg;
            bool valid = true;

            Console.WriteLine("Entra les hores: ");
            hores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entra els minuts: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entra els segons: ");
            seg = Convert.ToInt32(Console.ReadLine());

            if (hores > 23 || min > 59 || seg > 59) valid = false;

            if (!valid) Console.WriteLine("El format no es valid");

            else
            {

                seg = seg + 1;

                if (seg > 59) { min = min + 1; seg = 0; }

                if (min > 59) { hores = hores + 1; min = 0; seg = 0; }

                if (hores > 23) { hores = 0; min = 0; seg = 0; }



                Console.WriteLine($"La hora afegint un segon és: {hores} {min} {seg}");
            }

            }
        }
    }
