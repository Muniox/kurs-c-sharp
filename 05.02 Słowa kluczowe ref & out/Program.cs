namespace _05._02_Słowa_kluczowe_ref___out
{
    internal class Program
    {
        static void Double(int value)
        {
            value = 2 * value;
            Console.WriteLine($"Double value {value}");

        }
        static void Main(string[] args)
        {
            int someValue = 5;
            Double(someValue);

            Console.WriteLine($"some value: {someValue}");
        }
    }
}
