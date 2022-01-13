using System;

namespace nr_prim_exercitiu_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,d;
            bool prim = true;
            d = 2;
            Console.WriteLine("Introduceti nr. n: ");
            n = Int32.Parse(Console.ReadLine());

            while(d <= n/2 )
            {
                d += 1;
                if (n % d == 0)
                    prim = false;
                }

            if (prim)
            {
                Console.WriteLine("Numarul {0} este prim", n);
            }
            else
            {
                Console.WriteLine("Numarul {0} nu este prim", n);
            }

        }
    }
}
