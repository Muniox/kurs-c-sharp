namespace _06._01_Obsługa_plików_tekstowych
{
    internal class Program
    {
        static void ReadFiles()
        {
            var document1 = File.ReadAllText(@"C:\Users\Muniox\Desktop\dotnet\TextFiles\Read\document1.txt");
            var document2 = File.ReadLines(@"C:\Users\Muniox\Desktop\dotnet\TextFiles\Read\document2.txt");

            var document2String = string.Join(Environment.NewLine, document2);

            Console.WriteLine("document1----------------------------------------------------------------------------------");
            Console.WriteLine(document1);

            Console.WriteLine("document2----------------------------------------------------------------------------------");
            Console.WriteLine(document2String);
        }

        static void GenerateDocuments()
        {
            Console.WriteLine("Insert name:");
            var name = Console.ReadLine();

            Console.WriteLine("Insert orderNumber:");
            var orderNumber = Console.ReadLine();

            var template = File.ReadAllText(@"C:\Users\Muniox\Desktop\dotnet\TextFiles\Write\template.txt");
            var document = template.Replace("{name}", name).Replace("{orderNumber}", orderNumber).Replace("{dateTime}", DateTime.Now.ToString());

            File.WriteAllText(@$"C:\Users\Muniox\Desktop\dotnet\TextFiles\Write\document-{name}.txt", document);
        }

        static void Main(string[] args)
        {
            //File.ReadAllLines(); // zwraca tablicę stringów które są podzielone znakami nowej linii
            //File.ReadAllText(); // zwraca jeden wielki string

            //File.WriteAllText(); // przyjmuje string
            //File.WriteAllLines(); // przujuje tablice stringów które będą podzielone znakami nowej linii

            //ReadFiles();
            GenerateDocuments();
        }
    }
}
