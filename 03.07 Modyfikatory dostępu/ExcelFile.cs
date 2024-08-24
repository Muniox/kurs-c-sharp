using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._07_Modyfikatory_dostępu
{
    internal class ExcelFile : File
    {

        public void GeneratedReport()
        {
            // string prop = PrivateProp; //error
            string prop = ProtectedProp;
            Console.WriteLine($"{FileName} report..");
        }
    }
}
