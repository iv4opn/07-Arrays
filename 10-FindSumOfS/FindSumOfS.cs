using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FindSumOfS
    {
        static void Main()
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

            int[] array = {4, 3, 1, 4, 2, 5, 8 };
            int S = int.Parse(Console.ReadLine());
            int searchSum = 0;
            int findSum = int.MinValue;
            int count = 0;
            int startIndx = 0;
            int endIndx = 0;

            while (count < array.Length)
            {
                for (int i = count; i < array.Length; i++)
                {
                    searchSum += array[i];
                    if (searchSum == S)
                    {
                        findSum = searchSum;
                        startIndx = count;
                        endIndx = i;
                    }
                }
                searchSum = 0;
                count++;
            }

            Console.Write("Indices of the elements are:\n", S);
            for (int i = startIndx; i <= endIndx; i++)
            {
                Console.WriteLine("[{0}]={1}", i, array[i]);
            }

        }
    }

