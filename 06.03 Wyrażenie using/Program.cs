namespace _06._03_Wyrażenie_using
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\..\..\TextFiles\File\file.txt";
            var fileContent = File.ReadAllLines(filePath);

            using (var readFileStream = new FileStream(filePath, FileMode.Open))
            {
                // readFileStream.Read();
                // ...
                // throw new Exception();
            } // blok using mozemy wykonac dla kazdej klasy ktora dziedziczy po IDisposable



            // należy zamknąć stream przed jego ponownym wykorzystaniem
            // readFileStream.Close();

            var writeFileStream = new FileStream(filePath, FileMode.Open);

            // writeFileStream.Write();
            // readFileStream.Close();
        }
    }
}