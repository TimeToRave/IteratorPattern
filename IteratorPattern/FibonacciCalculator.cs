using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class FibonacciCalculator
    {
        /// <summary>
        /// Получает наиболее подходящий итератор
        /// для формирования последовательноти Фибоначчи
        /// </summary>
        /// <param name="order">Направление формирования последовательности</param>
        /// <param name="initial">Начальный шаг, с которого будет строиться последовательность</param>
        /// <param name="steps">Количество шагов, которые будут выполнены итератором</param>
        /// <returns>Итератор</returns>
        public FibonacciIterator GetFibonacciIterator(string order, int initial, int steps)
        {
            Dictionary<string, FibonacciIterator> availableMethods = new Dictionary<string, FibonacciIterator>()
            {
                {"ASC", new FibonacciAscIterator(initial, steps)},
                {"DESC", new FibonacciDescIterator(initial, steps)}
            };

            try
            {
                var iterator = availableMethods[order];
                return iterator;
            }
            catch (Exception)
            {
                return new FibonacciAscIterator(initial, steps);
            }

        }
    }
}