using System;

namespace _2_ecuatie_grad2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, x1, x2, d;
            Console.WriteLine("Dati coeficientii ecuatiei");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if (a != 0)
            {
                d = b * b - 4 * a * c;
                if (d < 0)
                    Console.WriteLine("Radacini complexe");
                else
                {
                    x1 = (float)(-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("X1={0}", x1);
                    Console.WriteLine("X2={0}", x2);
                }
            }
            else
            {
                if (b != 0)
                {
                    x1 = -c / b;
                    Console.WriteLine("Ec grad 1: X1={0}", x1);
                }
                else
                {
                    if (c == 0)
                        Console.WriteLine("Identitate");
                    else
                        Console.WriteLine("Ecuatie imposibila");
                }
            }
        }
    }
}
                   
