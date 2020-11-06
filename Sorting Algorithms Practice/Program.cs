using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static int[] tomb = new int[10];
        static void Main(string[] args)
        {
            sort_1();
        }

        static void random_nums()
        {
            Random random = new Random();
            int num = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                num = random.Next(0, 100);
                tomb[i] = num;
                Console.WriteLine(tomb[i]);
            }
        }

        // Egyszerű cserés rendezés (Quicksort)
        static void sort_1()
        {
            random_nums();
            Console.WriteLine();
            
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int l = i+1; l < tomb.Length; l++)
                {
                    if (tomb[i] > tomb[l])
                    {
                        num1 = tomb[i];
                        num2 = tomb[l];
                        tomb[i] = tomb[l];
                        tomb[l] = num1;
                    }
                }
                Console.WriteLine(tomb[i]);
            }
        }
    }
}
