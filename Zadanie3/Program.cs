namespace Zadanie3
{
    internal class Program
    {
        /*
         * Zadanie:
         * Utwórz aplikację konsolową króra imituję
         * zachowanie aplikacji z kontaktami na 
         * telefonie.
         * Kontakt to: nazwa i numer telefonu.
         * Aplikacja powinna:
         * 1. Dodawać kontakty
         * 2. Wyświetlać kontakt na podstawie numeru
         * 3. Wyświetlić wszystkie kontakty
         * 4. Wyszukać kontakty dla danej nazwy
         * **/

        static Dictionary<int, Contact> GetContacts()
        {
            return new Dictionary<int, Contact>();
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app");
        }
    }
}
