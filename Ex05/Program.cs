using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seg, dies = 0, hores = 0, minuts = 0, segons = 0;

            Console.WriteLine("Escriu el numero en segons: ");
            seg = Convert.ToInt32(Console.ReadLine());

            segons = seg % 60; // Calcula els segons

            if (seg >= 60)
            {
                minuts = (seg / 60) % 60; // Calcula els minuts
                if (seg >= 3600)
                {
                    hores = (seg / 3600) % 24; // Calcula les hores
                    if (seg >= 86400)
                    {
                        dies = seg / 86400; // Calcula els dies
                    }
                }
            }

            Console.WriteLine($"{dies} dies, {hores} hores, {minuts} minuts, {segons} segons");
        }
    }
}
