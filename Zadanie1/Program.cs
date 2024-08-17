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
            string input =  Console.ReadLine() ?? "0";

            DateTime dateOfBirth = DateTime.Parse(input);
            int daysFromDateOfBirth = (DateTime.Now.Year - dateOfBirth.Year) * 365 + DateTime.Now.DayOfYear - dateOfBirth.DayOfYear;
            Console.WriteLine(daysFromDateOfBirth);
        }
    }
}
