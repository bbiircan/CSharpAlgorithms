using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Yol Fibonacci
            ulong number1 = 1;
            ulong number2 = 1;
            ulong sum = 0;
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            for (int i = 1; i < 100; i++)
            {
                sum = number1 + number2;
                number1 = number2;
                number2 = sum;
                Console.WriteLine(sum);
            }
            Console.ReadKey();

            //    //2.Yol Fibonacci
            //    double sayi, s1 = 0, s2 = 1, nextterm;
            //    Console.WriteLine("Terim sayısını girin");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    for (int counter = 1; counter <= sayi; counter++)
            //    {
            //        Console.WriteLine("{0}", s1);
            //        nextterm = s1 + s2;
            //        s1 = s2;
            //        s2 = nextterm;

            //    }
            //    Console.ReadLine();
            //}
        }
    }
}
