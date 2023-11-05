using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bir kelime giriniz");
            //string x = Console.ReadLine().ToLower();
            //int count = 1;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    for (int j = 1; j < x.Length; j++)
            //    {

            //        if (x[i] == x[j])
            //        {
            //            count++;

            //            Console.WriteLine(x[i] + ":{0}", count);
            //        }
            //        else
            //        {

            //        }
            //    }
            //}

            //Console.ReadLine();



                Console.WriteLine("Bir kelime giriniz");
                string x = Console.ReadLine().ToLower();
                List<char> kontrolEdilenler = new List<char>(); // Daha önce kontrol edilen karakterleri tutar

                for (int i = 0; i < x.Length; i++)
                {
                    int count = 1;

                    // Eğer bu karakter daha önce kontrol edilmediyse:
                    if (!kontrolEdilenler.Contains(x[i]))
                    {
                        for (int j = i + 1; j < x.Length; j++)
                        {
                            if (x[i] == x[j])
                            {
                                count++;
                            }
                        }
                        kontrolEdilenler.Add(x[i]);
                        Console.WriteLine(x[i] + ":{0}", count);
                    }
                }

                Console.ReadLine();
            }
        }
    }

    

