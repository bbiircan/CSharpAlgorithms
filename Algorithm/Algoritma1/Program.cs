using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int uzunluk = number.ToString().Length;
            int start = number;
            int total = 0;
            while (number != 0)
            {
                int basamak = number % 10;
                total += Convert.ToInt32(Math.Pow(basamak, uzunluk));
                number /= 10;
            }
            if (total == start)
                Console.WriteLine("Armstrong Sayıdır");
            else
                Console.WriteLine("Armstrong sayı değildir."); 
                Console.ReadLine();
        }
    }
}
