namespace IteratorPattern
{
    public class FibonacciDescIterator : FibonacciIterator
    {

        public FibonacciDescIterator(int initial, int stepsCount)
        {
            Position = initial;
            StepCount = initial - stepsCount;
        }

        public override bool MoveNext()
        {
            bool isNext = -- Position > StepCount;

            return isNext;
        }
    }
}