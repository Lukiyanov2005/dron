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
                case 3:
                    Console.WriteLine($"Результат: {a * b}");
                    break;
                case 4:
                    if (b != 0)
                        Console.WriteLine($"Результат: {a / b}");
                    else
                        Console.WriteLine("Ошибка: деление на ноль");
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
