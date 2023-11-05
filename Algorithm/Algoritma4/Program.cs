using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Kelimeyi giriniz : ");
            string text1 = Console.ReadLine();
            Console.WriteLine("2. Kelimeyi giriniz : ");
            string text2 = Console.ReadLine();
            int count = 0; // eşit karakterleri saymak için
            for (int i = 0; i < text1.Length; i++)
            {
                for (int j = 0; j < text2.Length; j++)
                {
                    if (text1[i] == text2[j])
                    {
                        count++; // şartın içerisine her girdiğinde sayaç 1 artar.
                    }
                }
            }
            if (text1.Length == count) //kelime ile sayaç eşitse anagramdır.
            {
                Console.WriteLine("{0} ile {1} kelimeleri anagramdır.", text1, text2);
            }
            else
            {
                Console.WriteLine("{0} ile {1} kelimeleri anagram değildir..", text1, text2);

            }
            Console.ReadLine();
        }
    }
}
