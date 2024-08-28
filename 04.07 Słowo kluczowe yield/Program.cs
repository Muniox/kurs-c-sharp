namespace _04._07_Słowo_kluczowe_yield
{
    internal class Program
    {
        public static IEnumerable<int> GetData()
        {
            Console.WriteLine("Get data start");

            var result = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Get data element: {i}");
                result.Add(i);
            }

            Console.WriteLine("Get data end");

            return result;
        }

        public static IEnumerable<int> GetYieldData()
        {
            Console.WriteLine("GetYieldData start");

            for (int i = 0; i < 9; i++) 
            {
                Console.WriteLine($"Get yield element: {i}");
                yield return i;
                if( i % 3 == 0)
                {
                    yield break;
                }
            }

            Console.WriteLine("GetYieldData stop");
        }

        static void Main(string[] args)
        {
            var yieldedData = GetYieldData();
            foreach (var element in yieldedData)
            {
                Console.WriteLine($"main element: {element}");
            }

            var data = GetData();
            foreach (var element in data)
            {
                Console.WriteLine($"main element: {element}");
            }
        }
    }
}
