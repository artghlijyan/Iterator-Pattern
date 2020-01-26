using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
        public abstract object this[int index] { get; set; }
    }
}
