using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== КАЛЬКУЛЯТОР ===");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.Write("Выберите операцию: ");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Результат: {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Результат: {a - b}");
                    break;
                default:
                    Console.WriteLine("Операция пока не реализована");
                    break;
            }
        }
    }
}
