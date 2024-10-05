using System.Diagnostics;

namespace _07._03_Struktura_DateTime_w_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTimeModification();
            // DateTimeFormatting();
            // TimeMeasurement();
            DateTimeHelpers();
        }

        static void DateTimeModification()
        {
            DateTime now = DateTime.Now;
            DateTime openDate = new DateTime(1992, 6, 17);

            TimeSpan result = now - openDate;

            Console.WriteLine(result.Days); // TimeSpan w całych dniach
            Console.WriteLine(result.TotalDays); // TimeSpan w dniach z ułamkiem (dolicza ułamek długości dnia)

            // nie możemy dodawać do siebie dwóch dat(co jest dziwne jakbyśmy mogli), ale możemy dodawać jakąś stałą liczbe
            DateTime expiresAt = now.AddDays(7);
            DateTime expiresAt2 = now.Add(new TimeSpan(7, 1, 0, 0));

            Console.WriteLine(expiresAt);
            Console.WriteLine(expiresAt2);

            bool expiresAtTheSameDay = expiresAt == expiresAt2;
            Console.WriteLine($"expiresAtTheSameDay: {expiresAtTheSameDay}"); // mimo, że daty są takie same daje nam false, poniewaz porownywana jes rowniez godz.

            bool expiresAtTheSameDay2 = expiresAt.Date == expiresAt2.Date;
            Console.WriteLine($"expiresAtTheSameDay2: {expiresAtTheSameDay2}"); // otrzymamy true, ponieważ porównujemy jedynie daty
        }

        static void DateTimeFormatting()
        {
            // w jaki sposób można sformatować date do konkretnej postaci:
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("g"));
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss"));
        }

        static void TimeMeasurement()
        {
            Console.WriteLine("What is 2+2?");
            Console.WriteLine("A)4");
            Console.WriteLine("B)6");
            Console.WriteLine("C)8");

            // Stopwatch stopwatch = Stopwatch.StartNew(); //można też wykożystać metody statyczne stopwatch
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string userAnswer = Console.ReadLine();

            stopwatch.Stop();

            Console.WriteLine($"Response took you {stopwatch.Elapsed} Seconds");
        }

        static void DateTimeHelpers()
        {
            int daysInFeb2021 = DateTime.DaysInMonth(2021, 2);
            bool is2021LeapYear = DateTime.IsLeapYear(2021);

            Console.WriteLine($"daysInFeb2021: {daysInFeb2021}");
            Console.WriteLine($"is2021LeapYear: {is2021LeapYear}");
        }
    }
}