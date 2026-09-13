using System;
using System.Collections;
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
            //Euler 1. Complete

            //int a = 0; //Project Euler 1: the sum of all multiples of 3 or 5 up to 1000
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        a += i;
            //    }
            //}
            //WriteLine(a); //Correct

            //Euler 2. Complete

            //int[] fibonnaci = new int[50000]; //Project Euler 2: the sum of all even numbers in the fibonnaci sequence not exceeding 4 million
            //fibonnaci[0] = 1;
            //fibonnaci[1] = 2;
            //int b = 0;
            //for (int i = 2; fibonnaci.Max() <= 4000000; i++)
            //{
            //    fibonnaci[i] = fibonnaci[i - 1] + fibonnaci[i - 2];
            //} //Calculating fibbonaci
            //for (int e = 0; e < 50000; e++)
            //{
            //    if (fibonnaci[e] % 2 == 0)
            //    {
            //        b += fibonnaci[e];
            //    }
            //}
            //WriteLine(b); //Correct

            //Euler 3. Complete

            //const long bignum = 600851475143;  //Project Euler 3: Prime factors of 600851475143
            //double max = Math.Floor(Math.Sqrt(bignum)); //Square root it to get the range of values to test if prime
            //ArrayList primeNums = new ArrayList();
            //primeNums = PrimeList(max);
            //ArrayList primeFactors = new ArrayList();
            //for (int i = 0; i < primeNums.Count; i++)
            //{
            //    if (bignum % Convert.ToInt32(primeNums[i]) == 0) //If number is a factor
            //    {
            //        primeFactors.Add(primeNums[i]);
            //    }
            //}
            //for (int j = 0; j < primeFactors.Count; j++)
            //{
            //    Console.Write(primeFactors[j] + ", ");
            //} // Correct, largest prime factor is 6857

            //Euler 4. Complete

            //string multiple = "0"; //Project Euler 4: Largest palindromic number that is a multiple of two 3 digit numbers
            //string biggestPalindrome = "0"; //Definitely not the most efficient way
            //for (int i = 100; i <= 999; i++) //Range of 3-digit values
            //{
            //    for (int j = 100; j <= 999; j++)
            //    {
            //        multiple = Convert.ToString(i * j); //Multiple of the digits
            //        if (multiple.Length == 5) //brute forced it. length is either 5 or 6.
            //        {
            //            if (multiple.Substring(0, 1) == multiple.Substring(4, 1))
            //            {
            //                if (multiple.Substring(1, 1) == multiple.Substring(3, 1))
            //                {
            //                    if (Convert.ToInt32(multiple) > Convert.ToInt32(biggestPalindrome)) //Biggest comparison
            //                    {
            //                        biggestPalindrome = multiple;
            //                    }
            //                }
            //            }
            //        }
            //        else if (multiple.Length == 6)
            //        {
            //            if (multiple.Substring(0, 1) == multiple.Substring(5, 1))
            //            {
            //                if (multiple.Substring(1, 1) == multiple.Substring(4, 1))
            //                {
            //                    if (multiple.Substring(2, 1) == multiple.Substring(3, 1))
            //                    {
            //                        if (Convert.ToInt32(multiple) > Convert.ToInt32(biggestPalindrome))
            //                        {
            //                            biggestPalindrome = multiple;
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //WriteLine(biggestPalindrome);

            //Euler 7.Complete

            //ArrayList primes = new ArrayList(); //Project Euler 7 10,001st prime number
            //primes = PrimeList(999999);
            //Console.WriteLine(primes[10000]);


        }
        static ArrayList PrimeList (double maxNum) //Generates list of primes within the answer
        {
            ArrayList primeNums = new ArrayList(Convert.ToInt32(maxNum)); //ArrayList is array but you can add values and there is no set data type
            int potentialPrime = 0;
            bool isPrime = true;
            primeNums.Add(2);
            primeNums.Add(3);
            for (potentialPrime = 4; potentialPrime < maxNum; potentialPrime++) //all values between 2 and the max provided
            {
                isPrime = true; //start true so it only changes if not prime
                for (int i = 2; i <= Math.Floor(Math.Sqrt(potentialPrime)); i++) //Square root to find the range of factors. <= becausre sqrt can be an integer. Math.floor just for the sake of it.
                {
                    if (potentialPrime % i == 0) //If has a factor
                    {
                        isPrime = false;
                        break; 
                    }
                }
                if (isPrime)
                {
                    primeNums.Add(potentialPrime); //adds to list if prime
                }
            }
            return primeNums;
        }
    }
}
