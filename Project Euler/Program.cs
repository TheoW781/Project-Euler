using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            //Euler10();
            Euler11();





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
            for (int e = 0; e < 5000; e++)
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

        static void Euler7() //Project Euler 7: 10,001st prime number. Completed
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

        static void Euler10() //Project Euler 10: Sum of all primes below 2 million. Complete
        {
            List<int> Primes = SieveofEratosthenes(2000000);
            int[] primesArray = Primes.ToArray();
            long primeSum = 0; //set primeSum to long because that seems to work better
            for (int i = 0; i < primesArray.Length; i++)
            {
                primeSum += primesArray[i];
            }
            WriteLine(primeSum);

            ArrayList primes = PrimeList(2000000);
            long primeSums = 0;
            for (int i = 0; i < primes.Count; i++)
            {
                primeSums += ToInt32(primes[i]);
            }
            WriteLine(primeSums); //Correct 142913828922
        }

        static void Euler11() //Project Euler 11: Largest product in a grid. Complete
        {
            int[,] integerGrid = { {08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08 },
                                   { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00 },
                                   { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65 },
                                   { 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91 },
                                   { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 },
                                   { 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 },
                                   { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 },
                                   { 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21 },
                                   { 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 },
                                   { 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95 },
                                   { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92 },
                                   { 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57 },
                                   { 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 },
                                   { 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40 }, 
                                   { 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 },
                                   { 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 },
                                   { 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36 },
                                   { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16 },
                                   { 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54 },
                                   { 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48 } }; //The integers as a 2D array

            int largestProduct = 1;
            int placeholder = 1; //Both are one because multiplying by 0 gives 0
            //This one is for horizotal adjacents.
            for (int i = 0; i < 20; i++) //Index 1 (Columns)
            {
                for (int j = 0; j < 17; j++) //Index 2 (Rows). j < 17 so j + k does not exceed 20
                {
                    for (int k = 0; k < 4; k++) //K is used to get the next 3 consecutive values after j
                    {
                        placeholder *= integerGrid[i, j + k];
                    }
                    largestProduct = (placeholder > largestProduct) ? placeholder : largestProduct; //Ternay to compare largestProduct with placeholder
                    placeholder = 1;
                }
            }
            WriteLine(largestProduct); //Test
            placeholder = 1; //For debugging purposes, when skipping the first loop

            //Vertical adjacents
            for (int a = 0; a < 20; a++) //Index 2 (Row)
            {
                for (int b = 0; b < 17; b++) //Index 1 (Column)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        placeholder *= integerGrid[b + c, a];
                    }
                    largestProduct = (placeholder > largestProduct) ? placeholder : largestProduct;
                    placeholder = 1;
                }
            }

            //Diagonal forward adjacents.
            for (int x = 0; x < 17; x++) //Index 1 (Column)
            {
                for (int y = 0; y < 17; y++) //Index 2 (Row)
                {
                    for (int z = 0; z < 4; z++)
                    {
                        placeholder *= integerGrid[x + z, y + z];
                    }
                    largestProduct = (placeholder > largestProduct) ? placeholder : largestProduct;
                    placeholder = 1;
                }
            }

            //Diagonal backwards adjacents. Originally forgot this was an option
            for (int f = 3; f < 20; f++) //Index 1 (Column). Starts at 3 so doesn't go out of bounds
            {
                for (int g = 0; g < 17; g++) //Index 2 (Row)
                {
                    for (int h = 0; h < 4; h++)
                    {
                        placeholder *= integerGrid[f - h, g + h]; //
                    }
                    largestProduct = (placeholder > largestProduct) ? placeholder : largestProduct;
                    placeholder = 1;
                }
            }
            WriteLine(largestProduct);//Correct!! 70600674

            //Can combine it into one, here it is below, do need 4 placeholders though.
            int placeholderVertical = 1;
            int placeholderHorizontal = 1;
            int placeholderDiagonalForward = 1;
            int placeholderDiagonalBack = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    for (int  k = 0; k < 4; k++)
                    {
                        placeholderVertical *= (j < 17) ? integerGrid[i, j + k] : 1; //Ternary here to ensure no out of bounds, if j > 17, j + k might be greater than 19
                        placeholderHorizontal *= (j < 17) ? integerGrid[j + k, i] : 1; //Multiply by 1 instead of multiplying by an out of bounds index
                        placeholderDiagonalForward *= (i < 17 && j < 17) ? integerGrid[i + k, j + k] : 1;
                        placeholderDiagonalBack *= (i > 2 && j < 17) ? integerGrid[i - k, j + k] : 1;
                    }
                    largestProduct = (placeholderVertical > largestProduct) ? placeholderVertical : largestProduct;
                    largestProduct = (placeholderHorizontal > largestProduct) ? placeholderHorizontal : largestProduct;
                    largestProduct = (placeholderDiagonalForward > largestProduct) ? placeholderDiagonalForward : largestProduct;
                    largestProduct = (placeholderDiagonalBack > largestProduct) ? placeholderDiagonalBack : largestProduct; //Compare them all to largest product
                    placeholderVertical = 1;
                    placeholderDiagonalBack = 1;
                    placeholderDiagonalForward = 1;
                    placeholderHorizontal = 1; //Reset them all back to 1.
                }
            }
            WriteLine(largestProduct); //Still correct
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
