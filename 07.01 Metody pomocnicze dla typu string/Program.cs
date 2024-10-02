namespace _07._01_Metody_pomocnicze_dla_typu_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            string userInput = Console.ReadLine();


            SubString(userInput);
            Replace(userInput);
            Modify(userInput);
            AlterTextCase(userInput);
            Split(userInput);
            CheckString(userInput);
        }

        static void SubString(string userInput)
        {
            if (userInput.Length > 10)
            {
                // "this is some value".Substring(5) => "is some value"
                string startSubstring = userInput.Substring(0, 10);
                string endSubstring = userInput.Substring(userInput.Length - 10);
                Console.WriteLine($"{startSubstring}..., ...{endSubstring}");
                Console.WriteLine(userInput);
            }
        }

        static void Replace(string userInput)
        {
            string template = "Hello {name} how are you";
            string output = template.Replace("{name}", userInput);

            Console.WriteLine(output);
        }

        static void Modify(string userInput)
        {
            string removedString = userInput.Remove(5);
            // string substring = userInput.Substring(5);

            // Console.WriteLine(removedString);
            // Console.WriteLine(substring);

            string insertedString = userInput.Insert(5, "INSERT");
            Console.WriteLine(insertedString);

            string trimmedString = userInput.Trim();
            Console.WriteLine(trimmedString);
        }

        static void AlterTextCase(string userInput)
        {
            string upperCased = userInput.ToUpper();
            string lowerCased = userInput.ToLower();

            Console.WriteLine(upperCased);
            Console.WriteLine(lowerCased);
        }

        static void Split(string userInput)
        {
            string[] inputParts = userInput.Split(" ");
            string firstname = inputParts[0];
            string lastName = inputParts[inputParts.Length - 1];
            Console.WriteLine($"Hello {firstname} {lastName}");

        }

        static void CheckString(string userInput)
        {
            bool isTextFile = userInput.EndsWith(".txt");
            bool startsWithDocPrefix = userInput.StartsWith("doc-");

            bool containsText = userInput.Contains("text");
            bool containsText2 = userInput.Contains("TEXT", StringComparison.CurrentCultureIgnoreCase); // StringComparison.CurrentCultureIgnoreCase możemy dodać do startWith i endsWith

            Console.WriteLine($"isTextFile: {isTextFile}");
            Console.WriteLine($"startsWithDocPrefix: {startsWithDocPrefix}");
            Console.WriteLine($"containsText: {containsText}");
            Console.WriteLine($"containsText2: {containsText2}");
        }
    }
}