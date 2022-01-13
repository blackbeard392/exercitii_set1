using System;

namespace _15_3numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Introduceti 3 numere: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int[] numere = {a,b,c};
            Array.Sort(numere);
            for (int i = 0; i < 3; i++)
                Console.Write(numere[i] + " ");
            
        }
    }
}
