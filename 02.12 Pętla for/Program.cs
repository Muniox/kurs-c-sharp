namespace _02._12_Pętla_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };


            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }

            Console.ReadKey(true);
        }
    }
}
