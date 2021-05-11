using System;

namespace IteratorPattern
{
    public abstract class  FibonacciIterator
    {
        protected int StepCount { get; set; }
        protected int Position { get; set; }

        public abstract bool MoveNext();
        
        public int GetCurrent()
        {
            double sqrt5 = Math.Sqrt(5);
            double phi = (sqrt5 + 1) / 2;
            return Convert.ToUInt16(1 / sqrt5 * Math.Pow(phi, Position));
        }
    }
}