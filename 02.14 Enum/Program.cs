namespace _02._14_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is yor gender? 1 - Male, 2 - Female");
            string userInput = Console.ReadLine() ?? "0";

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if(userGender == Gender.Male)
            {
                Console.WriteLine("Only woman are allowed");
            } else
            {
                Console.WriteLine("Hi");
            }
        }
    }
}
