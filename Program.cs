using System;
namespace HomeTask_3_add_.NET
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введiть довiльне дiйсне число: ");
            int number = int.Parse(Console.ReadLine());
            int total = 0;

            if (number < 0)
            {
                number *= -1;
            }

            while (number != 0)
            {
                total += number % 10;
                number /= 10;
            }

            Console.Write($"Сума цифр введеного числа: {total}");
        }
    }
}
