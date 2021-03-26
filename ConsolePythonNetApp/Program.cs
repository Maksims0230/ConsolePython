using IronPython.Hosting;
using System;

namespace ConsolePythonNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var source = engine.CreateScriptSourceFromFile("calc.py");
            var scope = engine.CreateScope();
            source.Execute(scope);
            var classCalculator = scope.GetVariable("myMatch");
            var calculatorInstance = engine.Operations.CreateInstance(classCalculator);
            Console.Write("Введите выражение: ");
            var match = Console.ReadLine();
            Console.WriteLine($"Результат: {calculatorInstance.calc(match)}");
            Console.ReadLine();
        }
    }
}
