using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project_Euler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; //Project Euler 1: the sum of all multiples of 3 or 5 up to 1000
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    a += i;
                }
            }
            WriteLine(a); //Correct



            int[] fibonnaci = new int[50000]; //Project Euler 2: the sum of all even numbers in the fibonnaci sequence not exceeding 4 million
            fibonnaci[0] = 1;
            fibonnaci[1] = 2;
            int b = 0;
            for (int i = 2; fibonnaci.Max() <= 4000000; i++)
            {
                fibonnaci[i] = fibonnaci[i - 1] + fibonnaci[i - 2];
            } //Calculating fibbonaci
            for (int e = 0; e < 50000; e++)
            {
                if (fibonnaci[e] % 2 == 0)
                {
                    b += fibonnaci[e];
                }
            }
            WriteLine(b); //Correct


            int[] factors = new int[1000000]; //Project Euler 3: Largest prime factor of 600851475143
            for (int i = 0; i < 600851475143; i++)
            {
                
            }
        }
    }
}
