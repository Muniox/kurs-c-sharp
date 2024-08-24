using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._10_Polimorfizm
{
    internal class Shape
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    internal class Circle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }

    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }

    internal class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Triangle");
        }
    }
}
