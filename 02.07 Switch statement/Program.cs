namespace _02._07_Switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch(DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday :(");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("It's last day of the work week.");
                    break;

                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The Weekend");
                    break;

                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }
        }
    }
}
