namespace _02._08_Konwersja_typów_i_rzutowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteValue = 100;
            int intValue = byteValue;
            byte byteValue2 = (byte)intValue;
            double doubleValue = 3.5;
            int inValue2 = (int)doubleValue; //3


            string stringValue2 = inValue2.ToString();

            string userInput = Console.ReadLine() ?? "0";
            int yearOfBirth;
                if(!int.TryParse(userInput, out yearOfBirth))
            {
                Console.WriteLine("Incorect value!");
                return;
            }

            float floatValue = float.Parse(userInput);
            short shortValue = short.Parse(userInput);

            int age = DateTime.Now.Year - yearOfBirth;

            Console.WriteLine("You are " + age);

           Console.ReadKey(true);
        }
    }
}
