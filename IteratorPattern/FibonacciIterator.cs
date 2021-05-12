using System;

namespace IteratorPattern
{
    /// <summary>
    /// Общий класс-итератор для вывода последовательности Фибоначчи
    /// </summary>
    public abstract class  FibonacciIterator
    {
        /// <summary>
        /// Количество шагов, которые будут выполнены итератором
        /// </summary>
        protected int StepCount { get; set; }
        
        /// <summary>
        /// Начальный шаг, с которого будет строиться последовательность
        /// </summary>
        protected int Position { get; set; }

        /// <summary>
        /// Определяет возможность генерации
        /// следующего элемента последовательности
        /// </summary>
        /// <returns>Логическое значение - будет ли генерироваться следующий элемент</returns>
        public abstract bool MoveNext();
        
        /// <summary>
        /// Метод получения текущего числа последовательности
        /// </summary>
        /// <returns></returns>
        public int GetCurrent()
        {
            double sqrt5 = Math.Sqrt(5);
            double phi = (sqrt5 + 1) / 2;
            return Convert.ToUInt16(1 / sqrt5 * Math.Pow(phi, Position));
        }
    }
}