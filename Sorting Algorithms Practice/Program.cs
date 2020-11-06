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
            // sort_1();
            int[,] szamok = new int[7, 2] {
                 {2, 3} ,   
                 {4, 7} ,  
                 {0, 0} ,
                 {2, 9} ,
                 {1, 2} ,
                 {8, 3} ,
                 {0, 5} ,             
                        };
            Console.WriteLine("\nKiindulási állapot:");
            kiir(szamok);

            // Sortin 2D arrays
            // Feladat: Rendezd a kétdimenziós tömb tartalmát az első oszlop szerint csökkenő sorrendben!
            // kódod kezdete
            int num1 = 0;
            int num2 = 0;

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int l = i + 1; l < szamok.GetLength(0); l++)
                {
                    if (szamok[i, 0] < szamok[l, 0])
                    {
                        num1 = szamok[i, 0];
                        num2 = szamok[i, 1];
                        szamok[i, 0] = szamok[l, 0];
                        szamok[l, 0] = num1;
                        szamok[i, 1] = szamok[l, 1];
                        szamok[l, 1] = num2;
                    }
                }
            }
            // kódod vége

            Console.WriteLine("\nRendezve:");
            kiir(szamok);

            Console.ReadKey();
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

        static void kiir(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                 Console.WriteLine("{0}\t{1}",nums[i, 0],nums[i, 1]);    
            }
        }
    }
}
