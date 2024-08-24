using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._08_Klasa_abstrakcyjna
{
    internal class WordDocumentFile : File //można dziedziczyć tylko z jednej klasy bazowej
    {

        public override void Compress()
        {
            Console.WriteLine("Compressing WordDocumentFile");
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} Printing..");
        }
    }
}
