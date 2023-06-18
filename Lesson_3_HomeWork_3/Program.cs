using System;

namespace Lesson_3_HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Prompt (string message)
            {
                Console.WriteLine(message);
                return int.Parse(Console.ReadLine());
            }

            int x = Prompt("Введите число: ");
            int i = 1;
            while (i<=x)
            {
                Console.Write(Math.Pow(i, 3));
                if (Math.Pow(i, 3) != Math.Pow(x, 3))
                Console.Write(", ");
                i++;
            }

        }
    }
}
