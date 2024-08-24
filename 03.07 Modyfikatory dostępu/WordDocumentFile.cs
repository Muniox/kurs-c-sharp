using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._07_Modyfikatory_dostępu
{
    internal class WordDocumentFile : File
    {
        public void Print()
        {
            Console.WriteLine($"{FileName} Printing..");
        }
    }
}
