using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Circle
    {
        double radius;

        // constructor (shares same name as the class)
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateCircumference()
        {
            double circumference = ((2 * Math.PI) * radius);
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            double result;
            result = CalculateCircumference();
            return FormatNumber(result);
        }
        public double CalculateArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public string CalculateFormattedArea()
        {
            double result;
            result = CalculateArea();
            return FormatNumber(result);
        }

        private string FormatNumber(double x)
        {
            return String.Format("{0:0.00}", x);
        }
    }
}
