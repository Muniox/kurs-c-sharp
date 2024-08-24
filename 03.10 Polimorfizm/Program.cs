namespace _03._10_Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Circle(), new Rectangle(), new Triangle(),
            };

            foreach (Shape shape in shapes) 
            {
                shape.Draw();
            }

        }
    }
}
