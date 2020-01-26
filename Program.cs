using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate aggregate = new ConcreteAggregate();

            aggregate[0] = "Element a";
            aggregate[1] = "Element b";
            aggregate[2] = "Element c";
            aggregate[3] = "Element d";


            Iterator iterator = aggregate.CreateIterator();

            Console.WriteLine("Collection First Element");

            object element = iterator.First();
            Console.WriteLine(element);

            Console.WriteLine("------------------");

            Console.WriteLine("Iteration over Collection");
            while (!iterator.IsDone())
            {
                Console.WriteLine(element);
                element = iterator.Next();
            }
        }
    }
}
