namespace _04._05_Słownik_Dictionary_
{
    internal class Program
    {
        static List<Currency> GetCurrencies()
        {
            return new List<Currency>
            {
                new Currency("usd", "United States, Dollar", 1),
                new Currency("eur", "Euro", 0.83975),
                new Currency("gbp", "British Pund", 0.74771),
                new Currency("cad", "Canadian Dollar", 1.30724),
                new Currency("inr", "Indian Rupee", 73.04),
                new Currency("mxn", "Mexican Peso", 21.7571)
            };
        }
        static void Main(string[] args)
        {
            List<Currency> currencies = GetCurrencies();
            Console.WriteLine("Check the rate for:");
            string? userInpurt = Console.ReadLine();

            Currency? selectedCurrency = currencies.FirstOrDefault(c => c.Name == userInpurt);
            if(selectedCurrency != null)
            {
                Console.WriteLine($"Rate for USD to {selectedCurrency.Name} is {selectedCurrency.Rate}");
            }
            else
            {
                Console.WriteLine("Currency not found");
            }
        }
    }
}
