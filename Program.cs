using System;

namespace liczby_parzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj podaj liczbe do sprawdzenia");
            while (true)
            {
                int number = GetInput();
                if (number%2==1)
                {
                    Console.WriteLine("liczba jest nieparzysta");

                }
                else if(number%2 == 0)
                {
                    Console.WriteLine("liczba jest parzysta");
                }

                Console.WriteLine("Podaj następna liczbe lub wpisz 'e' żeby wyjść");
            }
        }

        private static int GetInput()
        {
            while (true)
            {
                var val = Console.ReadLine();
                if (val.ToUpper() == "E")
                {
                    Environment.Exit(0);
                }
                if (!int.TryParse(val,out int number))
                {
                    Console.WriteLine("Podales złe dane");
                    continue;
                }
                return number;
            }
            
        }
    }
}
