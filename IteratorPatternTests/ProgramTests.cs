using IteratorPattern;
using NUnit.Framework;

namespace IteratorPatternTests
{
    public class ProgramTests
    {
        /// <summary>
        /// Проверяет формирование последовательности Фибонначи для 10 позиций
        /// </summary>
        [Test]
        public void GetFibonacciConsequence_0_10()
        {
            var calculator = new FibonacciCalculator();
            var result = calculator.GetConsequence(0, 10);

            string etalon = "1 1 2 3 5 8 13 21 34 55 "; 
            Assert.AreEqual(etalon, result.Replace("\r\n", " "));
        }
        
        /// <summary>
        /// Проверяет формирование последовательности Фибоначчи в обратном порядке
        /// </summary>
        [Test]
        public void GetFibonacciConsequence_10_negative10()
        {
            var calculator = new FibonacciCalculator();
            var result = calculator.GetConsequence(10, -10);

            string etalon = "34 21 13 8 5 3 2 1 1 "; 
            Assert.AreEqual(etalon, result.Replace("\r\n", " "));
        }
    }
}