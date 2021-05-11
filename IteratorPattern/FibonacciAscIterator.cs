namespace IteratorPattern
{
    public class FibonacciAscIterator : FibonacciIterator
    {

        public FibonacciAscIterator(int initial, int stepsCount)
        {
            Position = initial;
            StepCount = initial + stepsCount;
        }

        public override bool MoveNext()
        {
            bool isNext = ++ Position < StepCount;

            return isNext;
        }
    }
}