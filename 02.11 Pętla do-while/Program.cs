using System.Diagnostics;

namespace _02._11_Pętla_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To exit, type 'x'");

            string userInput;

            do
            {
                userInput = Console.ReadLine();
                Console.WriteLine($"Echo: {userInput}");
            } while (userInput != "x");
        }
    }
}
