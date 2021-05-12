namespace IteratorPattern
{
    /// <summary>
    /// Итератор, проходящий по
    /// последовательности в обратном направлении
    /// </summary>
    public class FibonacciDescIterator : FibonacciIterator
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="initial">Начальный шаг</param>
        /// <param name="stepsCount">Количество шагов</param>
        public FibonacciDescIterator(int initial, int stepsCount)
        {
            Position = initial;
            StepCount = initial - stepsCount;
        }
        
        /// <summary>
        /// Определяет возможность генерации
        /// следующего элемента последовательности
        /// </summary>
        /// <returns>Логическое значение -
        /// будет ли генерироваться следующий элемент</returns>
        public override bool MoveNext()
        {
            bool isNext = -- Position > StepCount;

            return isNext;
        }
    }
}