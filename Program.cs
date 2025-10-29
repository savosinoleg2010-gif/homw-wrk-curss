using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        string playAgain;
        
        do
        {
            // Генерация нового числа для каждой игры
            int secretNumber = random.Next(1, 101);
            int userGuess = 0;
            int attempts = 0;
            const int maxAttempts = 7; // Максимальное количество попыток

            Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать!");
            Console.WriteLine($"У вас есть {maxAttempts} попыток.");

            // Основной игровой цикл (пока не угадали и не исчерпали попытки)
            while (userGuess != secretNumber && attempts < maxAttempts)
            {
                Console.Write("Ваша догадка: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }
            
            if (userGuess == secretNumber)
            {
                Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} за {attempts} попыток.");
            }
            else
            {
                Console.WriteLine($"Вы проиграли. Загаданное число было: {secretNumber}.");
            }

        
            Console.WriteLine("Хотите сыграть ещё раз? Введите 'да' или 'yes' для новой игры.");
            playAgain = Console.ReadLine();

        } while (playAgain == "да" || playAgain == "yes"); 
        
        Console.WriteLine("Спасибо за игру! Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}