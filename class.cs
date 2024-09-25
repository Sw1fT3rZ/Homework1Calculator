using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Консольний калькулятор");
            Console.WriteLine("Оберіть операцію:");
            Console.WriteLine("1. Додавання (+)");
            Console.WriteLine("2. Віднімання (-)");
            Console.WriteLine("3. Множення (*)");
            Console.WriteLine("4. Ділення (/)");
            Console.WriteLine("5. Вийти");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Вихід з програми.");
                break;
            }

            Console.Write("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Помилка: ділення на нуль.");
                    }
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }

            Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }
    }
}
