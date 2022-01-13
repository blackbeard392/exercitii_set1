using System;

namespace _18_FactorPrim
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Introduceti un numar: ");
            a = int.Parse(Console.ReadLine());

            for (b = 2; a > 1; b++)
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} este factor prim de {x} ori!");
                }
        }
    }
}
