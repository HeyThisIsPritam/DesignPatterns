using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    class FactoryTest
    {
        static void Main()
        {
            double n1, n2;
            Console.WriteLine("Enter number 1 : ");
            var a = Double.TryParse(Console.ReadLine(), out n1);
            if (!a)
            {
                Console.WriteLine("Ohh!! Didn't get you...Type again please");
                return;
            }
            Console.WriteLine("Enter number 2 : ");
            var b = Double.TryParse(Console.ReadLine(), out n2);
            if (!b)
            {
                Console.WriteLine("Ohh!! Didn't get you...Type again please");
                return;
            }
            Console.WriteLine("Please Select the shape between Rectangle and Triangle");
            FactoryClass factory = new FactoryClass();
            IArea result = factory.calculateArea(Console.ReadLine());
            result.area(n1,n2);

            Console.Read();
        }
    }
}
