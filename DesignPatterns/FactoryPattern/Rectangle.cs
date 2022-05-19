using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class Rectangle : IArea
    {
        public void area(double a,double b)
        {
            double result = a * b;
            Console.WriteLine("Area of the Rectangle is {0}",result);
        }
    }
}
