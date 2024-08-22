namespace _03._06_Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");

            bill.SetDateOfBirth(new DateTime(1990, 1, 1));

            bill.SayHi();
            bill.ContactNumber = "9998887776";
            Console.WriteLine(bill.ContactNumber);

            Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");

            john.SayHi();

            Console.WriteLine($"Pbjects of Person type count: {Person.Count}");
        }
    }
}
