using System.Runtime.CompilerServices;

namespace _04._02_Lista_i_jej_funkcjonalności
{
    internal class Program
    {
        static void DisplayElements(List<int> list)
        {
            Console.WriteLine("** List **");
            foreach (int element in list)
            {
                Console.Write($"{element}, ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 6, 1, 20, 3, 45, 60 , 100, 2 }; //wartość początkowa
            DisplayElements(intList);

            Console.WriteLine("New element:");
            string userInput = Console.ReadLine();
            int intValue = int.Parse(userInput);
            intList.Add(intValue);
            DisplayElements(intList);

            Console.WriteLine("Remove range");
            intList.RemoveRange(1, 2);
            DisplayElements(intList);

            Console.WriteLine("Sort");
            intList.Sort();
            DisplayElements(intList);


            //Console.ReadKey(); //potrzebne kiedy program działa poza solution
        }
    }
}
