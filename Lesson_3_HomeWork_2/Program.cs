using System;

namespace Lesson_3_HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
           double Prompt (string message)
            {
                Console.WriteLine(message);
                return double.Parse(Console.ReadLine());
            }
            double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
            {
                double res = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
                return res;
            }

            Console.WriteLine(Distance3D(Prompt("Введите X1: "), Prompt("Введите Y11: "), Prompt("Введите Z1: "), Prompt("Введите X2: "), Prompt("Введите Y2: "), Prompt("Введите Z2: ")));
        }
    }
}
