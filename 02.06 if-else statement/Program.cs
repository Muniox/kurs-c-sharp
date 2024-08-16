namespace project02._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year of birth?");
            string userInput = Console.ReadLine();

            int yearOfBerth = int.Parse(userInput);

            bool isUserOver18 = DateTime.Now.Date.Year - yearOfBerth > 18;

            if (isUserOver18)
            {
                Console.WriteLine("hello");
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            { 
            Console.WriteLine("Oh well its Sunday");
            }
            else {
                Console.WriteLine("Access dnied");
            }

            Console.WriteLine("bye");
        }
    }
}
