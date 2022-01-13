using System;

namespace n_divide
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, k;
            float x;
            Console.WriteLine("Valoare n:");
            n = float.Parse(Console.ReadLine());
            Console.WriteLine("Valoare k:");
            k = float.Parse(Console.ReadLine());
            x = n / k;
           

 
            if(x.GetType() == typeof(int) )
            {
                Console.WriteLine("Adevarat. n se divide cu k " + x);
            }else if(x.GetType() != typeof(int))
            {
                Console.WriteLine("False. n nu se divide cu k " + x);
            }            
               
            
        }
    }
}
