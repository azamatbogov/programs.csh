Console.OutputEncoding = System.Text.Encoding.UTF8;
static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выход");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlayGuessTheNumber();
                    break;
                case 2:
                    DisplayMultiplicationTable();
                    break;
                case 3:
                    DisplayDivisors();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                    break;
            }
        }
    }

    static void PlayGuessTheNumber()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int attempts = 0;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать.");

        while (true)
        {
            attempts++;
            Console.Write("Введите ваше предположение: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == targetNumber)
            {
                Console.WriteLine($"Поздравляю! Вы угадали число {targetNumber} за {attempts} попыток.");
                break;
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        }
    }

static void DisplayMultiplicationTable()
{
    int[,] multiplicationTable = new int[10, 10];

    Console.WriteLine("Таблица умножения:");

    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            multiplicationTable[i - 1, j - 1] = i * j;
        }
    }

    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            Console.Write($"{multiplicationTable[i - 1, j - 1]}\t");
        }
        Console.WriteLine();
    }
}

static void DisplayDivisors()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Делители числа {number}:");

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

Main();
