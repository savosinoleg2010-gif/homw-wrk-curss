
using System;

class Program
{
    static void Main(string[] args)
    {
        // Заголовки программы
        Console.WriteLine("--- Улучшенный калькулятор ---");
        
        // Переменные для чисел и операции
        double num1, num2;
        char operation;
        
        // Запрашиваем первое число
        Console.WriteLine("1. Введите первое число: ");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Ошибка: введено не число!");
            return;
        }
        
        // Запрашиваем второе число
        Console.WriteLine("2. Введите второе число: ");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Ошибка: введено не число!");
            return;
        }
        
        // Запрашиваем операцию
        Console.Write("3. Введите символ операции (+, -, *, /): ");
        if (!char.TryParse(Console.ReadLine(), out operation))
        {
            Console.WriteLine("Ошибка: неверный символ операции!");
            return;
        }
        
        // Обработка операции с помощью switch
        try
        {
            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Результат: {num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Результат: {num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Результат: {num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    Console.WriteLine($"Результат: {num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный символ операции!");
                    break;
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль невозможно!");
        }
        catch (Exception)
        {
            Console.WriteLine("Произошла ошибка при выполнении операции.");
        }
        
        // Завершение программы
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}


