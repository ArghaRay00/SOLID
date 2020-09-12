using System;
namespace solid
{
    class AreaCalculator
    {
        protected object[] shapes;

        public AreaCalculator(object[] objects)
        {
            shapes = objects;
        }

        public void Sum()
        {
            //logic  to  sum  the areas
        }

        public void Output()
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.Write("This is instance of " + shapes[i].ToString() + '\n');
            }

        }
    }
}