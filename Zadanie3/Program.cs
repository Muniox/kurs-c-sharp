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
            Console.WriteLine("1 Add contact");
            Console.WriteLine("3 Display contacy by number");
            Console.WriteLine("4 Search contacts");

            var userINput = Console.ReadLine();
            var phoneBook = new PhoneBook();

            switch (userINput)
            {
                case "1":
                    Console.WriteLine("Insert number");
                    var number = Console.ReadLine();
                    Console.WriteLine("Insert name");
                    var name = Console.ReadLine();

                    var contact = new Contact(name, number);
                    phoneBook.AddContact(contact);
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
    }
}
