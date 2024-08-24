using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._10_Polimorfizm
{
    internal class WordDocumentFile : IFile //można implementować wiele interfejsów
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public void Compress()
        {
            Console.WriteLine("Compressing WordDocumentFile");
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} Printing..");
        }
    }
}
