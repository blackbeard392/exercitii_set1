using System;

namespace swap_numere1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c,d;
            Console.WriteLine("Introduceti numarul a:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul b:");
            b = Int32.Parse(Console.ReadLine());
            c = a;
            d = b;

            a = d;
            Console.WriteLine("A= " + a);
            b = c;
            Console.WriteLine("B= " + b);
        }
    }
}
