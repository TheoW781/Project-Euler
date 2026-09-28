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


            WriteLine(" ");

            int[] fibonnaci = new int[5000]; //Project Euler 2: the sum of all even numbers in the fibonnaci sequence not exceeding 4 million
            fibonnaci[0] = 1;
            fibonnaci[1] = 2;
            int b = 0;
            for (int i = 2; fibonnaci.Max() <= 4000000; i++)
            {
                fibonnaci[i] = fibonnaci[i - 1] + fibonnaci[i - 2];
            } //Calculating fibbonaci
            for (int e = 0; e < 5000; e++)
            {
                if (fibonnaci[e] % 2 == 0)
                {
                    b += fibonnaci[e];
                }
            }
            WriteLine(b); //Correct

            WriteLine(" ");

            /*int[] factors = new int[1000000]; //Project Euler 3: Largest prime factor of 600851475143
            for (int i = 0; i < 600851475143; i++)
            {
                
            }
            int factor = 0;
            for (int i = 0; i < 1844674407370955161; i++) //Project Euler 5: smallest multiple of 1 to 20
            {
                if (i % 1 == 0 && i % 2 == 0 && i % 3 == 0 && i % 4 == 0 && i % 5 == 0 && i % 6 == 0 && i % 7 == 0 && i % 8 == 0 && i % 9 == 0 && i % 10 == 0 && i % 11 == 0 && i % 12 == 0 && i % 13 == 0 && i % 14 == 0 && i % 15 == 0 && i % 16 == 0 && i % 17 == 0 && i % 18 == 0 && i % 19 == 0 && i % 20 == 0)
                {
                    factor = i;
                    break;
                }
            }
            WriteLine(factor); 
            */
            WriteLine(" ");

            int powersum = 0;
            int sum = 0;
            for (int i = 1; i <= 100; i++) //Sum square difference
            {
                powersum += Convert.ToInt32(Math.Pow(i, 2));
                sum += i;
            }
            WriteLine(powersum - Convert.ToInt32(Math.Pow(sum,2)));

            WriteLine(" ");

            bool founds = false;
            for (int A = 0; A < 1000 && !founds; A++) //project Euler pythagorean triplet
            {
                for (int B = 0; B < 1000 && !founds; B++)
                {
                    for (int C = 0; C < 1000 && !founds; C++)
                    {
                        if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2) && A + B + C == 1000)
                        {
                            WriteLine(A * B * C);
                            founds = true;
                        }
                    }
                }
            }

            WriteLine(" ");

            //bool found = false; //1000 digit fibonnaci
            //for (int i = 2; i < 50000000; i++)
            //{
            //    fibonnaci[i] = fibonnaci[i - 1] + fibonnaci[i - 2];
            //} //Calculating fibbonaci
            //for (int i = 0; !found; i++) //Loop through fibonnaci
            //{
            //    if (Convert.ToString(fibonnaci[i]).Length == 1000) //length
            //    {
            //        WriteLine(fibonnaci[i]);
            //        found = true;
            //    }
            //} //too big

            WriteLine(" ");

            double square = Math.Pow(2, 1000); //power digit sum
            string squares = Convert.ToString(square);
            char[] separated = squares.ToCharArray();
            int Sum = 0;
            for (int i = 0; i < squares.Length; i++)
            {
                Sum += Convert.ToInt32(separated[i]);
            }
            WriteLine(Sum);


            bool founder = false; //smallest multiple
            int num = 100;
            while (!founder)
            {
                if (num % 20 == 0 && num % 19 == 0 && num % 18 == 0 && num % 17 == 0 && num % 16 == 0 && num % 15 == 0 && num % 14 == 0 && num % 13 == 0 && num % 12 == 0 && num % 11 == 0 && num % 10 == 0 && num % 9 == 0 && num % 8 == 0 && num % 7 == 0 && num % 6 == 0 && num % 5 == 0 && num % 4 == 0 && num % 3 == 0 && num % 2 == 0 && num % 1 == 0)
                {
                    WriteLine(num);
                    founder = true;
                }
                else
                {
                    num++;
                }
            }

            WriteLine(" "); //Square chains ending in 89
            int end89 = 0;
            int squareSum = 0;
            int store = 0;
            for (int i = 1; i < 1000000; i++)
            {
                store = i;
                for (int j = i; j < Convert.ToString(store).Length; j++)
                {
                    squareSum += (Convert.ToInt32(Convert.ToString(store).Substring(j, 1))) ^ 2;
                    if (squareSum == 89)
                    {
                        end89++;
                        break;
                    }
                    else if (squareSum == 1)
                    {
                        break;
                    }
                    store = squareSum;
                    squareSum = 0;
                }
                
            }
            WriteLine(end89);

        }
    }
}
