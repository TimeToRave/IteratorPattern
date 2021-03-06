using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class FibonacciCalculator
    {
        /// <summary>
        /// Получает наиболее подходящий итератор
        /// для формирования последовательноти Фибоначчи
        /// </summary>
        /// <param name="initial">Начальный шаг, с которого будет строиться последовательность</param>
        /// <param name="steps">Количество шагов, которые будут выполнены итератором</param>
        /// <returns>Итератор</returns>
        public FibonacciIterator GetFibonacciIterator(int initial, int steps)
        {
            Dictionary<string, FibonacciIterator> availableMethods = new Dictionary<string, FibonacciIterator>()
            {
                {"ASC", new FibonacciAscIterator(initial, steps)},
                {"DESC", new FibonacciDescIterator(initial, Math.Abs(steps))}
            };

            string orderName = GetIteratorOrder(steps);
            try
            {
                var iterator = availableMethods[orderName];
                return iterator;
            }
            catch (Exception)
            {
                return new FibonacciAscIterator(initial, steps);
            }

        }

        /// <summary>
        /// Определяет направление формирования последовательсности Фибоначчи
        /// Если количество шагов отрицательное, то производится обратный проход
        /// </summary>
        /// <param name="steps">Количество шагов</param>
        /// <returns>Название метода прохода</returns>
        public string GetIteratorOrder(int steps)
        {
            string order = "ASC";
            if (steps  < 0)
            {
                order = "DESC";
            }

            return order;
        }

        /// <summary>
        /// Формирует последовательность Фибоначчи
        /// </summary>
        /// <param name="initialStep">Начальный шаг, с которого будет строиться последовательность</param>
        /// <param name="stepsCount">Количество шагов</param>
        /// <returns>Строку с последовательностью числе Фибоначчи</returns>
        public string GetConsequence(int initialStep, int stepsCount)
        {
            var iterator = GetFibonacciIterator(initialStep, stepsCount);

            StringBuilder fibonacciSequence = new StringBuilder();
            while (iterator.MoveNext())
            {
                fibonacciSequence.AppendLine(iterator.GetCurrent().ToString());
            }

            return fibonacciSequence.ToString();
        }
    }
}