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
            AreaCalculator areas = new AreaCalculator(shapes);
            SumCalculatorOutputter output = new SumCalculatorOutputter(areas);
            // Different types of output
            output.HAML();
            output.HTML();
            output.JADE();
            output.JSON();
            Console.ReadLine();
        }
    }
}
