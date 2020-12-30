using System;

namespace ConsoleApp2
{
    class Program
    {
        delegate void Calculate(int a, int b, ref double result); // Объявляем делегат
        static void Main(string[] args)
        {
            double c = 0;
            Calculate calculate;
            calculate = Sub; // Добавляем методы
            calculate += Add;
            calculate += Div;
            calculate += Mul;
            calculate(56, 48, ref c); // Вводим значения
            Console.WriteLine();
            calculate -= Div; // Убираем деление
            calculate(46, 10, ref c);
            Console.ReadKey();
        }
        private static void Sub (int a, int b, ref double result)
        {
            Console.WriteLine(result);
            result = a - b;
            Console.WriteLine($"Результат вычитания: {result}");
        }
        private static void Add (int a, int b, ref double result)
        {
            Console.WriteLine(result);
            result = a + b;
            Console.WriteLine($"Результат сложения: {result}");
        }
        private static void Div (int a, int b, ref double result)
        {
            Console.WriteLine(result);
            result = a / b;
            Console.WriteLine($"Результат деления: {result}");
        }
        private static void Mul (int a, int b, ref double result)
        {
            Console.WriteLine(result);
            result = a * b;
            Console.WriteLine($"Результат умножения: {result}");
        }
    }
}
