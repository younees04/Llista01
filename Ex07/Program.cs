using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double import, paga , canvi;

            Console.WriteLine("Quin es el import a pagar? ");
            import = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quan ha pagat el client? ");
            paga = Convert.ToDouble(Console.ReadLine());

            canvi = paga - import;

            if(import > paga) 
            {
                Console.WriteLine("No hi han suficients diners");
            }

            else
            {
                Console.WriteLine("El canvi a tornar es de: " + canvi + " euros");

                int doseuros = (int)canvi / 2;
                canvi = canvi % 2;

                int uneuro = (int)canvi / 1;
                canvi = canvi % 1;

                int cinquantacent = (int)(canvi / 0.5);
                canvi = canvi % 0.5;

                int vintcent = (int)(canvi / 0.2);
                canvi = canvi % 0.2;

                int deucent = (int)(canvi / 0.1);
                canvi = canvi % 0.1;

                int cinccent = (int)(canvi / 0.05);
                canvi = canvi % 0.05;

                int doscent = (int)(canvi / 0.02);
                canvi = canvi % 0.02;

                int uncent = (int)(canvi / 0.01);
                canvi = canvi % 0.01;
                
                Console.WriteLine();

                Console.WriteLine("El canvi es de: ");
                Console.WriteLine("Moneda de dos euros: " + doseuros);
                Console.WriteLine("Moneda de un euro: " + uneuro);
                Console.WriteLine("Moneda de 50 centims: " + cinquantacent);
                Console.WriteLine("Moneda de 20 centims: " + vintcent);
                Console.WriteLine("Moneda de 10 centims: " + deucent);
                Console.WriteLine("Moneda de 5 centims: " + cinccent);
                Console.WriteLine("Moneda de 2 centims: " + doscent);
                Console.WriteLine("Moneda de 1 centim: " + uncent);

            }
        }
    }
}
