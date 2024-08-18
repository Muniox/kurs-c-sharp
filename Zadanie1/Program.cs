namespace Zadanie1
{
    internal class Program
    {
        /*
         * Zadanie
         * Utwórz aplikację konsolową, która
         * pobierze od użytkownika datę jego urodzin i na tej podstawie obliczy
         * ile minęło dno od tej daty do obecnego dnia.
         * **/
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the date of birth (dd.MM.yyyy)");
            string input =  Console.ReadLine() ?? "0";

            DateTime dateOfBirth = DateTime.Parse(input);
            
            TimeSpan timeSpan = DateTime.Now - dateOfBirth;


            Console.WriteLine($"You were born: {timeSpan.TotalDays} days ago");

            Console.ReadKey();
        }
    }
}
