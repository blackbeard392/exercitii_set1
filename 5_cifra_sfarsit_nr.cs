using System;

namespace _5_cifra_sfarsit_nr
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr;
            Console.WriteLine("Introduceti un numar: ");
            nr = Console.ReadLine().Length;
            Console.WriteLine("Ultima cifra din numar este {0}", nr-1);
        }
    }
}
