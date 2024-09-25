using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("���������� �����������");
            Console.WriteLine("������ ��������:");
            Console.WriteLine("1. ��������� (+)");
            Console.WriteLine("2. ³������� (-)");
            Console.WriteLine("3. �������� (*)");
            Console.WriteLine("4. ĳ����� (/)");
            Console.WriteLine("5. �����");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("����� � ��������.");
                break;
            }

            Console.Write("������ ����� �����: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("������ ����� �����: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"���������: {num1} + {num2} = {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"���������: {num1} - {num2} = {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"���������: {num1} * {num2} = {result}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"���������: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("�������: ������ �� ����.");
                    }
                    break;
                default:
                    Console.WriteLine("������� ����. ��������� �� ���.");
                    break;
            }

            Console.WriteLine("�������� ����-��� ������, ��� ����������...");
            Console.ReadKey();
        }
    }
}
