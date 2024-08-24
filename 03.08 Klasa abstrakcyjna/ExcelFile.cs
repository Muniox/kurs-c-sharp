using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._08_Klasa_abstrakcyjna
{
    internal class ExcelFile : File //można dziedziczyć tylko z jednej klasy bazowej
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing ExcelFile");
        }

        public void GeneratedReport()
        {
            // string prop = PrivateProp; //error
            string prop = ProtectedProp;
            Console.WriteLine($"{FileName} report..");
        }
    }
}
