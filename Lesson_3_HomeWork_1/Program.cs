using System;

namespace Lesson_3_HomeWork_1
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
            void IsPalindrome (int i)
            {
                int j = i;
                int res = 0;
                while (j>=1)   
                {
                    res = res*10 + (j%10); 
                    j = j/10;
                }
               
                if (res == i) 
                {
                    Console.WriteLine("Это число палиндром");
                } 
                else 
                {
                    Console.WriteLine("Это число не палиндром");
                }
            }

            int X = Prompt("Введите число: ");
            IsPalindrome(X);
        }
    }
}
