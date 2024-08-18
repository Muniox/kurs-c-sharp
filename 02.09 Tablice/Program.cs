namespace _02._09_Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"Volvo", "BMW", "Mazda"};
            string[] cars2 = [ "Volvo", "BMW", "Mazda" ]; // after C# 12
            Console.WriteLine(cars[0]);
            int arrayLength = cars.Length; //3

            cars[2] = "Tesla";


        }
    }
}
