using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class BuilderTest
    {
        static void Main()
        {
            BuildClass.ClassBuilder build = new BuildClass.ClassBuilder();
            var withName = build.withName("Pritam").GetObjectWithValue();
            Console.WriteLine("{0} {1} {2}",withName.Name, withName.ID, withName.Address);

            var withId = build.withId(123).GetObjectWithValue();
            Console.WriteLine("{0} {1} {2}",withId.Name, withId.ID, withId.Address);

            var withAddress = build.withAddress("Raniganj").GetObjectWithValue();
            Console.WriteLine("{0} {1} {2}",withAddress.Name, withAddress.ID, withAddress.Address);

            Console.WriteLine("\n--------------------------------------\n");
            Console.WriteLine("{0} {1} {2}",withName.GetHashCode(),withId.GetHashCode(),withAddress.GetHashCode());

            Console.Read();
        }
    }
}
