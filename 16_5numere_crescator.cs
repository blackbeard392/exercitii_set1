using System;

namespace _16_5numere_crescator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.WriteLine("Introduceti 5 numere: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            int[] numere = { a, b, c, d, e };
            Array.Sort(numere);
            for (int i =0; i< 5; i++)
            {
                Console.Write(numere[i] + " ");
            }
        }
    }
}
