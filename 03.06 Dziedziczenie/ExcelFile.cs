﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._06_Dziedziczenie
{
    internal class ExcelFile : File
    {

        public void GeneratedReport()
        {
            Console.WriteLine($"{FileName} report..");
        }
    }
}
