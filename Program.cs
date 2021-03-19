using System;

namespace Calculator
{
    class Program
    {
        static void Main1(string[] args)
        {
            int digit1 = 0, digit2;
            Console.Write("Введите 1 число: ");
            digit1 = int.Parse(Console.ReadLine());

            Console.Write("Введите 2 число: ");
            digit2 = int.Parse(Console.ReadLine());

            Console.Write("введите операцию: +, - , /, *, % : ");

            char action = char.Parse(Console.ReadLine());
            int result = 0;

            switch (action)
            {
                case '+':
                    result = digit1 + digit2;
                    break;
                case '-':
                    result = digit1 - digit2;
                    break;
                case '/':
                    result = digit1 / digit2;
                    break;
                case '*':
                    result = digit1 * digit2;
                    break;
                case '%':
                    result = digit1 % digit2;
                    break;
                default:
                    Console.WriteLine("Я не знаю такой операции");
                    break;
            }
            Console.WriteLine("" + digit1 + action + digit2 + "=" + result);


        }
    } 
}
