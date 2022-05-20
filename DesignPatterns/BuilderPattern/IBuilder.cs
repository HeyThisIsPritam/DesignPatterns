using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public interface IBuilder
    {
        string Name { get; }
        int ID { get; }
        string Address { get; }
    }
}
