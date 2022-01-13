using System;

namespace _9_divizorii_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;
            a = 0;
       
            Console.WriteLine("Introduceti un nr: ");
            n = int.Parse(Console.ReadLine());
            while(a <= n)
            {
                a++;
                if(n % a == 0)
                {
                    Console.WriteLine("Divizorii lui n sunt:{0}", a);
                }
            }
            
        }
    }
}
