using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class FactoryClass 
    {
        public IArea calculateArea(string type)
        {
            IArea obj = null;
            if (type.ToLower().Equals("rectangle"))
            {
                obj = new Rectangle();
                
            }
            else if (type.ToLower().Equals("triangle"))
            {
                obj = new Triangle();

            }
            else
            {
                Console.WriteLine("Sorry!!! Didn't get you.");
            }


            return obj;
        }
    }
}
