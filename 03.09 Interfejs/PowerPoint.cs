using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._09_Interfejs
{
    internal class PowerPoint : IFile //można implementować wiele interfejsów
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public void Compress()
        {
            Console.WriteLine("Compressing PowerPoint");
        }

        public void Present()
        {
            Console.WriteLine($"{FileName} presenting..");
        }
    }
}
