using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            double hight = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            Shape rec = new Rectangle(hight, width);

            Console.WriteLine(rec.CalculatePerimeter());
            Console.WriteLine(rec.CalculateArea());
            Console.WriteLine(rec.Draw());

            double radius = double.Parse(Console.ReadLine());

            Shape cir = new Circle(radius);

            Console.WriteLine(cir.CalculatePerimeter());
            Console.WriteLine(cir.CalculateArea());
            Console.WriteLine(cir.Draw());

        }
    }
}
