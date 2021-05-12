using System;
using System.Text;

namespace IteratorPattern
{
    static class Program
    {
        
        static void Main(string[] args)
        {
            int stepsCount = 0;
            int initialStep = 10;
            
            // Получает количество шагов
            var argumentsIsValid = args.Length > 0  ? int.TryParse(args[0], out stepsCount) : false;
            
            // Получает начальный шаг, с которого будут выполняться вычисления
            argumentsIsValid = args.Length > 1 && int.TryParse(args[1], out initialStep);
            // Получает название файла, в который будет производиться запись
            string outputFilePath = (args.Length > 2 && args[2].Length > 0) ? args[2] : "output.txt";
            
            var calculator = new FibonacciCalculator();
            string result = calculator.GetConsequence(initialStep, stepsCount);

            FileOperator fileOperator = new FileOperator();
            fileOperator.WriteTextToFile(outputFilePath, result);
            Console.ReadLine();
        }
    }
}