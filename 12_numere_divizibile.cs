using System;

namespace _12_numere_divizibile_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, nr;
            nr = 0;
            Console.WriteLine("Numere divizibile cu n in intervalul a b");
            Console.WriteLine("Valoare n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Valoare a= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valoare b= ");
            b = int.Parse(Console.ReadLine());

            if(a < b)
            {
                while(a <= b)
                {
                    a++;
                    if(a % n == 0)
                    {
                        nr++;
                    }
                }
                Console.WriteLine("Valoarea numarului este {0}",nr);
            }

        }
    }
}
