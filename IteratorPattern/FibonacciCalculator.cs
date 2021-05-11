using System.Collections.Generic;

namespace IteratorPattern
{
    public class FibonacciCalculator
    {
        public FibonacciIterator GetFibonacciIterator(string order, int initial, int steps)
        {
                
            Dictionary<string, FibonacciIterator> availableMethods = new Dictionary<string, FibonacciIterator>()
            {
                {"ASC", new FibonacciAscIterator(initial, steps)},
                {"DESC", new FibonacciDescIterator(initial, steps)}
            };
                
            var iterator = availableMethods[order];
            return iterator;
        }
    }
}