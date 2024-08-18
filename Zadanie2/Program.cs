namespace Zadanie2
{
    internal class Program
    {
        /* Zadanie
         * Utwórz aplikację konsolową, która będzie wczytywać
         * wartości liczbowe od użytkownika, dopóki nie poda on
         * wartości 0.
         * Podczas czytania, aplikacja powinna:
         * obliczyć sumę wszystkich elementów
         * znaleźć największy element
         * 
         * Po wczytaniu wartości 0, te dwie wartości powinny zostać 
         * wypisane w konsoli
         * **/
        static void Main(string[] args)
        {
            bool shouldConsoleStop = false;
            int numberSum = 0;
            int biggestNumber = 0;

            Console.WriteLine("Podaj numery: ");

            while (shouldConsoleStop != true)
            {
                string inputNumber = Console.ReadLine() ?? "0";
                int inputToNumber;

                if (!int.TryParse(inputNumber, out inputToNumber))
                {
                    Console.WriteLine("Please input only numbers!");
                    return;
                }

                if (inputToNumber == 0)
                {
                    shouldConsoleStop = true;
                }

                numberSum += inputToNumber;

                if (inputToNumber > biggestNumber)
                {
                    biggestNumber = inputToNumber;
                }
            }

            Console.WriteLine($"suma wszystkich elementów wynosi: {numberSum}");
            Console.WriteLine($"największa liczba to: {biggestNumber}");
        }
    }
}
