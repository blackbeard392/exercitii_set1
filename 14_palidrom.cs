using System;

namespace _14_palidrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar, reverse,copie_numar;
            reverse = 0;
            
            Console.WriteLine("Introduceti un nr: ");
            numar = int.Parse(Console.ReadLine());
            copie_numar = numar;
            while (numar > 0)
            {
                int remainder = numar % 10;
                reverse = (reverse * 10) + remainder;
                numar = numar / 10;
                
            }
            if (copie_numar == reverse)
            {
                Console.WriteLine("Numarul este un palidrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este un palidrom");
            }
        }
    }
}
