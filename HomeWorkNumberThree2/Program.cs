using System;

namespace HomeWorkNumberThree2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 1, z = 5;

            x = x + y - x++ * z;
            var a = 14 + 1 - 14 * 5;
            x++;
            x = a;
            x = Minus(Plus(x, y), Umnozh(x++, z));

            int b = z = --x - y * 5;
            int c = y /= x + 5 % z;
            int d = z = x++ + y * 5;
            int e = x = y - x++ * z;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.ReadKey();

        }

        static int Plus(int first, int second)
        {
            return first + second;
        }

        static int Minus(int first, int second)
        {
            return first - second;
        }

        static int Umnozh(int first, int second)
        {
            return first * second;
        }

        static int Delit(int first, int second)
        {
            return first / second;
        }
    }
}
