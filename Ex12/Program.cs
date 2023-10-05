using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radi;
            int opcio;

            Console.WriteLine("1_ Calcular Longitud d'una circumferencia");
            Console.WriteLine("2_ Calcular  l’àrea d’un cercle");
            Console.WriteLine("3_ Clacular el volum d'una esfera");
            Console.WriteLine();
            Console.Write("Entra l'opcio que vols: ");
            opcio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Entra el radi: ");
            radi = Convert.ToDouble(Console.ReadLine());

            double longitud, area, volum;

            longitud = 2 * Math.PI * radi;
            area = Math.PI * radi * radi;
            volum = 4 / 3 * Math.PI * radi * radi * radi;

            switch (opcio)
            {
                case 1:Console.WriteLine("La longitud de la teva circumferencia és de: " + longitud);
                    break;

                case 2:
                    Console.WriteLine("L'are del teu cercle és de: " + area);
                    break; 
                case 3:
                    Console.WriteLine("El volum de la teva esfera és de: " + volum);
                    break;
            }
         
        }
    }
}
