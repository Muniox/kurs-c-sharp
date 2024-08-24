using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._07_Modyfikatory_dostępu
{
    internal class File
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        protected string ProtectedProp { get; set; }

        private string PrivateProp { get; set; }
    }
}
