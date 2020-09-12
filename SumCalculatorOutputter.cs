using System;
namespace solid
{
    public class SumCalculatorOutputter
    {
        public AreaCalculator Output { get; set; }
        public SumCalculatorOutputter(AreaCalculator areaCalculator)
        {
            Output = areaCalculator;
        }

        public void JSON()
        {
            //JSON output
        }

        public void HAML()
        {

            //HAML output
        }
        public void HTML()
        {
            //HTML output
        }

        public void JADE()
        {
            //Jade output
        }
    }
}