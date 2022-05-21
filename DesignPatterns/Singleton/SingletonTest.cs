using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class SingletonTest
    {
        static void Main()
        {
            //singleton single1 = new singleton(); // here 2 diff object of same class has been creating
            //singleton single2 = new singleton();
            //Console.WriteLine(single1.GetHashCode());
            //Console.WriteLine(single2.GetHashCode());

            //Calling Singleton now
            //Singleton single1 = Singleton.GetSingleton();
            //Singleton single2 = Singleton.GetSingleton();
            //Console.WriteLine(single1.GetHashCode());
            //Console.WriteLine(single2.GetHashCode()); // now we can see we get the same hashcode , so other object is getting created here.

            Console.WriteLine("Same Functionality using Getter Setter");
            Singleton single3 = Singleton.Instance;
            Singleton single4 = Singleton.Instance;
            Console.WriteLine(single3.GetHashCode());
            Console.WriteLine(single4.GetHashCode());

            Console.Read();
        }
    }
}
