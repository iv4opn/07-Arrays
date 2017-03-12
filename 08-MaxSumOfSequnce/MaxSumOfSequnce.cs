using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaxSumOfSequnce
    {
        static void Main()
        {
            //Write a program that finds the sequence of maximal sum in given array. Example:
            //{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}

            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 }; 
            int searchSum = 0;
            int findSum = int.MinValue;
            int count = 0;
            int startIndx = 0;
            int endIndx = 0;

            while (count<array.Length)
	        {
                for (int i = count; i < array.Length; i++)
                {
                        searchSum += array[i];
                        if (searchSum > findSum)
	                    {
                            findSum = searchSum;
                            startIndx = count;
                            endIndx = i;
	                    }
                }
                searchSum = 0;
                count++;
            }

            Console.Write("Maximal sum is {0}.\nIndices of the elements are:\n", findSum);
            for (int i = startIndx; i <=endIndx; i++)
            {
                Console.WriteLine("[{0}]={1}", i, array[i]);
            }

        }
    }

