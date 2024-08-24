namespace _03._08_Klasa_abstrakcyjna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();

            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel-file";

            excelFile.GeneratedReport();

            WordDocumentFile wordDocumentFile = new WordDocumentFile();

            wordDocumentFile.CreatedOn = DateTime.Now;
            wordDocumentFile.FileName = "word-file";

            wordDocumentFile.Print();

            //File file = new File(); //jeśli nie chcemy aby można było tworzyć instancje klasy File musimy dać abstract

        }
    }
}
