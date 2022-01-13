using System;

namespace an_bisect
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Scrieti un an:");
             y = Int32.Parse(Console.ReadLine());
            if (y % 4 == 0 & y % 100 != 0 || y % 400 == 0 ) {
                Console.WriteLine("Adevarat. y este an bisect!");
            }else{
                Console.WriteLine("Fals. y nu este an bisect !");
            }
            
        }
    }
}
