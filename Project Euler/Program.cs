using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace Project_Euler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Euler1();
            //Euler2();
            //Euler3();
            //Euler4();
            //Euler7();
            //Euler8();
            Euler10();






        }

        static void Euler1() //Project Euler 1: the sum of all multiples of 3 or 5 up to 1000. Completed
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
        }

        static void Euler2() //Project Euler 2: the sum of all even numbers in the fibonnaci sequence not exceeding 4 million. Completed
        {
            int[] fibonnaci = new int[50000]; 
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
        }

        static void Euler3() //Project Euler 3: Prime factors of 600851475143. Completed
        {
            const long bignum = 600851475143;  
            double max = Math.Floor(Math.Sqrt(bignum)); //Square root it to get the range of values to test if prime
            ArrayList primeNums = new ArrayList();
            primeNums = PrimeList(max);
            ArrayList primeFactors = new ArrayList();
            for (int i = 0; i < primeNums.Count; i++)
            {
                if (bignum % Convert.ToInt32(primeNums[i]) == 0) //If number is a factor
                {
                    primeFactors.Add(primeNums[i]);
                }
            }
            for (int j = 0; j < primeFactors.Count; j++)
            {
                Console.Write(primeFactors[j] + ", ");
            } // Correct, largest prime factor is 6857
        }

        static void Euler4() //Project Euler 4: Largest palindromic number that is a multiple of two 3 digit numbers. Completed
        {

            string multiple = "0";
            string biggestPalindrome = "0"; //Definitely not the most efficient way
            for (int i = 100; i <= 999; i++) //Range of 3-digit values
            {
                for (int j = 100; j <= 999; j++)
                {
                    multiple = Convert.ToString(i * j); //Multiple of the digits
                    if (multiple.Length == 5) //brute forced it. length is either 5 or 6.
                    {
                        if (multiple.Substring(0, 1) == multiple.Substring(4, 1))
                        {
                            if (multiple.Substring(1, 1) == multiple.Substring(3, 1))
                            {
                                if (Convert.ToInt32(multiple) > Convert.ToInt32(biggestPalindrome)) //Biggest comparison
                                {
                                    biggestPalindrome = multiple;
                                }
                            }
                        }
                    }
                    else if (multiple.Length == 6)
                    {
                        if (multiple.Substring(0, 1) == multiple.Substring(5, 1))
                        {
                            if (multiple.Substring(1, 1) == multiple.Substring(4, 1))
                            {
                                if (multiple.Substring(2, 1) == multiple.Substring(3, 1))
                                {
                                    if (Convert.ToInt32(multiple) > Convert.ToInt32(biggestPalindrome))
                                    {
                                        biggestPalindrome = multiple;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            WriteLine(biggestPalindrome);
        }

        static void Euler7() //Project Euler 7 10,001st prime number. Completed
        { 
            ArrayList primes = new ArrayList(); //Get list of primes
            primes = PrimeList(999999);
            Console.WriteLine(primes[10000]); //Write the 10001st prime
        }

        static void Euler8()  //Project Euler 8: Largest product of 13 adjacent digits of the 100 digit number. Completed
        { 
            string bigNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            long largestnumber = 0; //Changed to long because some values exceeded int limit
            string temp = "";
            long tempNumber = 1; //Declaring as 1 so not always 0
            for (int i = 0; i < bigNumber.Length; i++) //Loop through until the end of the string
            {
                tempNumber = 1; //Reset tempNumber so not false.
                if (bigNumber.Length - i < 13) //No need to continue after the last 13 digit sequence is reached
                {
                    break;
                }
                else
                {
                    temp = bigNumber.Substring(i, 13); //Make a substring of length 13

                }
                for (int j = 0; j < 13; j++) //Multiply each digit together
                {
                    if (temp.Contains("0")) //Multiplt by 0 = 0
                    {
                        break;
                    }
                    tempNumber = tempNumber * ToInt32(temp.Substring(j, 1)); //Multiply the temporary number by the next value in the substring (Multiply by 1 if first in string)
                }
                largestnumber = (tempNumber > largestnumber) ? tempNumber : largestnumber; //Ternary operator. If condition true, assign tempNumber to largestnumber else remain

            }
            WriteLine(largestnumber); //Correct. 23514624000
        }

        static void Euler10() //Project Euler 10, Sum of all primes below 2 million. Complete
        {
            //List<int> Primes = SieveofEratosthenes(2000000); 
            //int[] primesArray = Primes.ToArray();
            //long primeSum = 0; //set primeSum to long because that seems to work better
            //for (int i = 0; i < primesArray.Length;i++)
            //{
            //    primeSum += primesArray[i];
            //}
            //WriteLine(primeSum);

            ArrayList primes = PrimeList(2000000);
            long primeSums = 0;
            for (int i = 0; i < primes.Count; i++)
            {
                primeSums += ToInt32(primes[i]);
            }
            WriteLine(primeSums); //Correct 142913828922
        }

        static ArrayList PrimeList (double maxNum) //Generates list of primes within the answer
        {
            ArrayList primeNums = new ArrayList(ToInt32(maxNum)); //ArrayList is array but you can add values and there is no set data type
            int potentialPrime = 0;
            bool isPrime = true;
            primeNums.Add(2);
            primeNums.Add(3);
            for (potentialPrime = 4; potentialPrime < maxNum; potentialPrime++) //all values between 2 and the max provided
            {
                isPrime = true; //start true so it only changes if not prime
                for (int i = 2; i <= Floor(Sqrt(potentialPrime)); i++) //Square root to find the range of factors. <= becausre sqrt can be an integer. Math.floor just for the sake of it.
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

        static List<int> SieveofEratosthenes(int maxNum) //Not my code, just used for proofing in case  mine does not work
        {
            List<int> primes = new List<int> (); //Create a list for ze primes
            bool[] isPrime = new bool[maxNum+1]; //Boolean array so a value is either Prime (true) or not (false)
            for (int p = 0; p <= maxNum; p++) //Declaring everything as true beforehand so it doesn't reset when looping
            {
                isPrime[p] = true; //Assume every number is prime until proven otherwise
            }
            int rootofMaxNum = ToInt32(Floor(Sqrt(maxNum)));
            for (int i = 2; i <= rootofMaxNum; i++) //i starts at 2, less than the square root of maxNum
            {
                if (isPrime[i])
                {
                    for (int j = i*i; j <= maxNum; j+= i) //all multiples of that number
                    {
                        isPrime[j] = false; //found the problem, has used i as the index instead of j
                    }
                }
            }
            for (int k = 2; k <= maxNum; k++) //Yeah
            {
                if (isPrime[k])
                {
                    primes.Add(k); //Add prime numbers to the list because they are true
                }
            }
            return primes;
        }
    }
}
