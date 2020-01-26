using System;
using System.Collections;

namespace IteratorPattern
{
    public class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList elements = new ArrayList();
        private ConcreateIterator iterator;

        public override object this[int index] 
        {
            get => elements[index]; 
            set => elements.Insert(index, value); 
        }

        public int Count => elements.Count;

        public override Iterator CreateIterator()
        {
            iterator = new ConcreateIterator(this);
            return iterator;
        }
    }
}
