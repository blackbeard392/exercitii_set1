using System;

namespace _17_divizor_multiplu
{
    class Program
    {
        static void Main(string[] args)
        {
         
            static int cel_mai_mare_divizor(int num1, int num2)

            {

                while (num1 != num2){
                    if (num1 > num2)
                        num1 = num1 - num2;
                    if (num2 > num1)
                        num2 = num2 - num1;
                }
                return num1;

            }

            static int cel_mai_mic_multiplu(int num1, int num2)

            {

                return (num1 * num2) / cel_mai_mare_divizor(num1, num2);

            }

            int a, b, divizor, multiplu;
            Console.WriteLine("Introduceti 2 numere:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            divizor = cel_mai_mare_divizor(a, b);
            multiplu = cel_mai_mic_multiplu(a, b);
            Console.WriteLine("Divizor {0}", divizor);
            Console.WriteLine("Multiplu {0}", multiplu);
        }
    }
}
