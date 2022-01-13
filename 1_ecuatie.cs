using System;

namespace ecuatie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.WriteLine("Dati coeficientii ecuatiei");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine("Solutia = {0}", x);
            }
            else
            {
                if (b == 0)
                    Console.WriteLine("Ecuatie nedeterminata");
                else
                    Console.WriteLine("Ecuatie imposibila");
            }
        }
    }
}

