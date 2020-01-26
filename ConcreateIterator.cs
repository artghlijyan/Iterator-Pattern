using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreateIterator : Iterator
    {
        private readonly ConcreteAggregate aggregate;
        private int current;

        public ConcreateIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }


        public override object First()
        {
            return aggregate[0];
        }
        public override object Next()
        {
            object element = null;
            current++;

            if (!IsDone())
            {
                element = aggregate[current];
                return element;
            }
            return null; ;
        }

        public override bool IsDone()
        {
            return current == aggregate.Count;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }
}
