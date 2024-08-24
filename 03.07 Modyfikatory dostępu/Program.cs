namespace _03._07_Modyfikatory_dostępu
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

        }
    }
}
