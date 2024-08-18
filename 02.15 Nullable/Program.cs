namespace _02._15_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? favoriteNumber = null;

            Console.WriteLine($"Favorite number {(favoriteNumber.HasValue ? favoriteNumber.Value.ToString() : "")}");
        }
    }
}
