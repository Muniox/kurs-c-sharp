namespace _04._06_Słowo_kluczowe_var
{
    internal class Program
    {
        static Dictionary<string, Currency> GetCurrencies()
        {
            return new Dictionary<string, Currency>
            {
                { "usd", new Currency("usd", "United States, Dollar", 1) },
                { "eur", new Currency("eur", "Euro", 0.83975) },
                { "gbp", new Currency("gbp", "British Pund", 0.74771) },
                { "cad", new Currency("cad", "Canadian Dollar", 1.30724) },
                { "inr", new Currency("inr", "Indian Rupee", 73.04) },
                { "mxn", new Currency("mxn", "Mexican Peso", 21.7571) }
            };
        }
        static void Main(string[] args)
        {
            var currencies = GetCurrencies();
            Console.WriteLine("Check the rate for:");
            var userInput = Console.ReadLine();

            var index = 1;
            var someText = "tests";


            Currency? selectedCurrency = null;
            if (currencies.TryGetValue(userInput, out selectedCurrency))
            {
                Console.WriteLine($"Rate for USD to {selectedCurrency.Name} is {selectedCurrency.Rate}");
            }
            else
            {
                Console.WriteLine("Currency not found");
            }

            currencies.Remove("usd");
            currencies.TryAdd("usd", new Currency("usd", "Dollar", 1));
        }
    }
}
