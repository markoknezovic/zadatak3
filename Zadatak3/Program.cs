using System;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            int uneseniBroj;

            Console.WriteLine(" Unesi broj: ");


            uneseniBroj = Convert.ToInt32(Console.ReadLine());

            if (uneseniBroj % 4 == 0 && uneseniBroj % 6 != 0)
            {

                Console.WriteLine(" Broj je djeljiv sa 4. ");

            }
            if (uneseniBroj % 4 != 0 && uneseniBroj % 6 == 0)

            {
                Console.WriteLine(" Broj je djeljiv sa 6. ");

            }

            if (uneseniBroj % 4 == 0 && uneseniBroj % 6 == 0)

            {

                Console.WriteLine(" Broj je djeljiv sa 4 i sa 6. ");

            }

            if (uneseniBroj % 4 != 0 && uneseniBroj % 6 != 0)

            {

                Console.WriteLine(" Broj nije djeljiv sa 4 i sa 6. ");

            }
            Console.ReadKey();

        }
    }
}