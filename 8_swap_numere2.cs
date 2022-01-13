using System;

namespace swap_numere2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Introduceti nr a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti nr b: ");
            b = Int32.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            
         
            
        }
    }
}
