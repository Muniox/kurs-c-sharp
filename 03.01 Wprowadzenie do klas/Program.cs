namespace _03._01_Wprowadzenie_do_klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person();
            bill.FirstName = "Bill";

            Console.WriteLine($"{bill.FirstName} {bill.DateOfBirth}");
        }
    }
}
