using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Entra el primer num: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entra el segon num: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == 0 || n2 == 0) throw new Exception("Un dels valor és 0");

            if (n1 % n2 == 0 || n2 % n1 == 0) Console.WriteLine("Si que son divisors entre ells");

            else Console.WriteLine("No son divisors entre ells");
        }
    }
}
