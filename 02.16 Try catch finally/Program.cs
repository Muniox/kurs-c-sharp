namespace _02._16_Try_catch_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };



            try
            {
                Console.WriteLine("Inside try -1");
                cars[4] = "Tesla"; // throws System.IndexOutOfRangeException
                Console.WriteLine("inside try -2");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Handling IndexOutOfRangeException exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("Handling any exception");
                // code wich is executed only when exception is caught
            }
            finally
            {
                Console.WriteLine("Cleanup");
            }

            Console.WriteLine("Outside of try-catch");
        }
    }
}
