﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._09_Interfejs
{
    internal interface IFile
    {
        string FileName { get; set; }
        int Size { get; set; }
        DateTime CreatedOn { get; set; }

        void Compress();
    }
}
