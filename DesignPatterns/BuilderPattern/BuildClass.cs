using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class BuildClass : IBuilder
    {
        private string name;
        private int id;
        private string address;
        private BuildClass() { }

        public string Name { get { return name; } }
        public int ID { get { return id; } }
        public string Address { get { return address; } }

        public class ClassBuilder
        {
            private BuildClass build;
            public ClassBuilder()
            {
                build = new BuildClass();
            }
            public ClassBuilder withName(string name)
            {
                build.name = name;
                return this;
            }
            public ClassBuilder withId(int id)
            {
                build.id = id;
                return this;
            }
            public ClassBuilder withAddress(string address)
            {
                build.address = address;
                return this;
            }
            public BuildClass GetObjectWithValue()
            {
                return build;
            }
        }
    }
}
