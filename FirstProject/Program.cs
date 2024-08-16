using System;


namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello");
            Console.WriteLine(userName);

            string someText = "Some text";

            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReady = true;

            DateTime now = DateTime.Now;
             
            DateTime dateOfBirth = new DateTime(1990, 9, 9);

            byte byteNumber = 250;
            
            float floatNumber = 1.5F;
            decimal decimalNumber = 1.5M;
            double doubleNumber = 1.5;


           

        }
    }

}
