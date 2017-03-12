using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PrimeNumbers
    {
        static void Main()
        {
            //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

            long size=10000000;
            bool [] array = new bool [size];      
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = true;
            }

            for (int j = 2; j < array.Length; j++)
            {
                if (array[j])
                {
                    for (long z = 2; (z * j) < array.Length; z++)
                    {
                        array[z * j] = false;
                    }
                }
            }

            for (int i = 2; i < array.Length; i++)
            {
                if (array[i])
                {
                    Console.WriteLine(i);

                }

            }

        }
    }

