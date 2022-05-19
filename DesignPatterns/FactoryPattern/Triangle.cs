using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class Triangle : IArea
    {
        public void area(double a, double b)
        {
            double result = (0.5 * a * b);
            Console.WriteLine("Area of the Triangle is {0}", result);
        }
    }
}
