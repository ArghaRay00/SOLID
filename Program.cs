using System;

namespace solid
{
    class Program
    {

        static void Main(string[] args)
        {
            object[] shapes ={
            new Circle(2),
            new Square(5),
            new Square(6)
        };
            AreaCalculator areaCalculator = new AreaCalculator(shapes);
            areaCalculator.Output();
            Console.ReadLine();
        }
    }
}
