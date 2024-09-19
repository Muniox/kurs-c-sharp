namespace Zadanie4
{
    internal class Program
    {
        static bool TryParseToNegative(string input, out int result)
        {
            if (int.TryParse(input, out result))
            {
                if (result < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                result = default;
                return false;
            }
        }

        static void Main(string[] args)
        {
            int inputValue;

            while (!TryParseToNegative(Console.ReadLine(), out inputValue))
            {
                Console.WriteLine("Insert negative number");
            }

            Console.WriteLine($"Inserted nagative number = {inputValue}");
        }
    }
}
