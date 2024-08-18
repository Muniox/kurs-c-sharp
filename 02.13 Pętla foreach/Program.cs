namespace _02._13_Pętla_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };

            foreach (string car in cars) 
            { 
                Console.WriteLine(car);
                if (car == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }

            Console.ReadKey(true);
        }
    }
}
