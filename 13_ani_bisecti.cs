using System;

namespace _13_ani_bisecti
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1, y2;
            int ani = 0;
            Console.WriteLine("Introduceti primul an bisect: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea an bisect: ");
            y2 = int.Parse(Console.ReadLine());

            if(y1 < y2)
            {
                while(y1 <= y2)
                {
                    if((y1 % 4 == 0 & y1 % 100 != 0)||y1 % 400 == 0)
                    {
                        ani++;  
                    }
                    y1++;
              }
                Console.WriteLine("Numarul anilor bisecti este {0}", ani);
            }else if (y2 < y1)
            {
                while(y2 <= y1)
                {
                    if ((y2 % 4 == 0 & y2 % 100 != 0) || y2 % 400 == 0)
                    {
                        ani++;
                    }
                    y2++;
                }
                Console.WriteLine("Numarul anilor bisecti este {0}", ani);
            }
        }
    }
}
