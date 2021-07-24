using System;

namespace HomeWorkNumberThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double i;
            const double PI = 3.141;

            Console.WriteLine("Введите значение радиуса основания");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение образующей");
            i = Convert.ToDouble(Console.ReadLine());

            double S = PI * r * (r + i);
            Console.WriteLine(S);

            Console.ReadKey();
        }
    }
}
