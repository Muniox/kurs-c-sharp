using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02_Lista_i_jej_funkcjonalności
{
    internal class Remove
    {
        public void RemoveTypeFuctions()
        {
            List<int> intList1 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
            intList1.RemoveAt(2); // value 20 removed -> [ 6, 1, 3, 45, 60, 100, 2]



            bool IsGreaterThan5(int x)
            {
                return x > 5;
            }
            List<int> intList2 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };

            intList2.RemoveAll(IsGreaterThan5); // values 6, 20 , 45, 60, 100 removed -> [1, 3, 2]

            List<int> intList3 = new List<int>() { 1, 2, 1};
            intList3.Remove(1); // value 1 removed -> [2, 1]


            List<int> intList4 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
            // RemoveRange od jakiej pozycji, a drugi parametr ile ma usunąć
            intList4.RemoveRange(2, 3); // value 20, 3 , 45 removed -> [6, 1, 60, 100, 2]
        }
    }
}
