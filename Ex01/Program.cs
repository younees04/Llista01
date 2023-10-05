namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, resultat;

            Console.WriteLine("Escriu el primer num: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriu el segon num: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriu el tercer num: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num1 > num3) resultat = num1;

            else if (num2 > num1 && num2 > num3) resultat = num2;

            else if (num3 > num1 && num3 > num2) resultat = num3;

            else resultat = 0; //son iguals

            Console.WriteLine("El numero mes gran és: " + resultat);
        }

    }
}