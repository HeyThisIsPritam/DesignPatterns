using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class Singleton //Sealed keyword is used to prevent any kind of inheritance.
    {
        private static Singleton singleton; // we also create a instace in the class level - 2
                                            // we also need to make it static - 5
        private Singleton() // making the default constructor private we restrict in to instantiated in SingletonTest.cs - 1
        {

        }

        public static Singleton GetSingleton() // here we are providing condition to check if any object is already created or not - 3
        {                                       // we make this method static to get called without creating any object in Main class i.e, SingletonTest.cs - 4
            if (singleton == null)
                singleton = new Singleton();
            return singleton;
        }

        public static Singleton Instance // We can write it in C# manner as well using Getter Setter
        {
            get
            {
                if (singleton == null)
                    singleton = new Singleton();
                return singleton;
            }
        }

        //public class Derived : Singleton { }  // Using sealed keyword in Base class makes the Singleton pattern more effective.
                                               //Otherwise it can beinherited and thus ended up creating many objects of the same class
                                               //which violate the Singleton. 

    }
    
}
