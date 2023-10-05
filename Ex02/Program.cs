namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultat=0;

            Console.WriteLine("Escriu el primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriu el segon numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                resultat = n1 - n2;
                Console.WriteLine("El valor absolut de els dos valors es: " + resultat);
            }


            else if (n1 < n2)
            {   resultat = n2 - n1;
                Console.WriteLine("El valor absolut de els dos valors es: " + resultat);
            }


            else Console.WriteLine("Els dos valors son iguals");

        }
    }
}