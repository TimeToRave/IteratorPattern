using System.Text;
using IteratorPattern;
using NUnit.Framework;

namespace IteratorPatternTests
{
    public class FibonacciAscIteratorTests
    {
        /// <summary>
        /// Проверка корректности вычисления числа Фибоначчи на 10 позиции
        /// </summary>
        [Test]
        public void FibonacciIterator_GetFibonacciNumber_position10()
        {
            var iterator = new FibonacciAscIterator(10, 1);
            var fibonacciNumberFor10 = iterator.GetCurrent();
            ulong etalon = 55;
            Assert.AreEqual(etalon, fibonacciNumberFor10);
        }
        
        /// <summary>
        /// Проверка корректности вычисления числа Фибоначчи на 0 позиции
        /// </summary>
        [Test]
        public void FibonacciIterator_GetFibonacciNumber_position0()
        {
            var iterator = new FibonacciAscIterator(0, 1);
            var fibonacciNumberFor0 = iterator.GetCurrent();
            ulong etalon = 0;
            Assert.AreEqual(etalon, fibonacciNumberFor0);
        }
        
        /// <summary>
        /// Проверка корректности вычисления числа Фибоначчи на 1 позиции
        /// </summary>
        [Test]
        public void FibonacciIterator_GetFibonacciNumber_position1()
        {
            var iterator = new FibonacciAscIterator(1, 1);
            var fibonacciNumberFor1 = iterator.GetCurrent();
            ulong etalon = 1;
            Assert.AreEqual(etalon, fibonacciNumberFor1);
        }
        
        /// <summary>
        /// Проверка корректности вычисления признака продолжения
        /// расчета последовательности для прямого прохода
        /// </summary>
        [Test]
        public void FibonacciAscIterator_MoveNext_MoveTo()
        {
            var iterator = new FibonacciAscIterator(0, 1);
            var isNext = iterator.MoveNext();
            
            Assert.IsTrue(isNext);
        }
        
        /// <summary>
        /// Проверка корректности вычисления признака продолжения
        /// расчета последовательности для прямого прохода
        /// Заданы параметры, при котороых расчет должен заверршиться
        /// </summary>
        [Test]
        public void FibonacciAscIterator_MoveNext_ShouldStop()
        {
            var iterator = new FibonacciAscIterator(1, 1);
            var isNext = iterator.MoveNext() && iterator.MoveNext();
            
            Assert.IsFalse(isNext);
        }
        
        /// <summary>
        /// Проверка корректности вычисления признака продолжения
        /// расчета последовательности для обратного прохода
        /// </summary>
        [Test]
        public void FibonacciDescIterator_MoveNext_MoveTo()
        {
            var iterator = new FibonacciDescIterator(10, 5);
            var isNext = iterator.MoveNext();
            
            Assert.IsTrue(isNext);
        }
        
        /// <summary>
        /// Проверка корректности вычисления признака продолжения
        /// расчета последовательности для обратного прохода
        /// Заданы параметры, при котороых расчет должен заверршиться
        /// </summary>
        [Test]
        public void FibonacciDescIterator_MoveNext_ShouldStop()
        {
            var iterator = new FibonacciDescIterator(1, 1);
            var isNext = iterator.MoveNext() && iterator.MoveNext();
            
            Assert.IsFalse(isNext);
        }
        
        /// <summary>
        /// Проверка корректности получения итератора
        /// Должен создаваться экземпляр итератора прямого прохода
        /// </summary>
        [Test]
        public void GetFibonacciIterator_GetAscIterator()
        {
            var calculator = new FibonacciCalculator();
            var iterator = calculator.GetFibonacciIterator(0, 10);
            
            Assert.IsInstanceOf(typeof(FibonacciAscIterator), iterator);
        }
        
        /// <summary>
        /// Проверка корректности получения итератора
        /// Должен создаваться экземпляр итератора обратного прохода
        /// </summary>
        [Test]
        public void GetFibonacciIterator_GetDescIterator()
        {
            var calculator = new FibonacciCalculator();
            var iterator = calculator.GetFibonacciIterator(10, -5);
            
            Assert.IsInstanceOf(typeof(FibonacciDescIterator), iterator);
        }
        
        /// <summary>
        /// Проверяет метод определения направления прохода
        /// При положительном значении количества шагов - прямой
        /// </summary>
        [Test]
        public void GetFibonacciIterator_GetIteratorOrder_Asc_For0()
        {
            var calculator = new FibonacciCalculator();
            var orderName = calculator.GetIteratorOrder(0);

            string etalon = "ASC";
            Assert.AreEqual(etalon, orderName);
        }
        
        /// <summary>
        /// Проверяет метод определения направления прохода
        /// При положительном значении количества шагов - прямой
        /// </summary>
        [Test]
        public void GetFibonacciIterator_GetIteratorOrder_Asc_ForNormalCount()
        {
            var calculator = new FibonacciCalculator();
            var orderName = calculator.GetIteratorOrder(10);

            string etalon = "ASC";
            Assert.AreEqual(etalon, orderName);
        }
        
        /// <summary>
        /// Проверяет метод определения направления прохода
        /// При отрицательном значении количества шагов - обратный
        /// </summary>
        [Test]
        public void GetFibonacciIterator_GetIteratorOrder_Desc()
        {
            var calculator = new FibonacciCalculator();
            var orderName = calculator.GetIteratorOrder(-10);

            string etalon = "DESC";
            Assert.AreEqual(etalon, orderName);
        }
        
        
    }
}