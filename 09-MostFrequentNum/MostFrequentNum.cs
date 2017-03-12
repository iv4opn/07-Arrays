using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MostFrequentNum
    {
        static void Main()
        {
            //Write a program that finds the most frequent number in an array. Example:
            //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int maxCount=0;
            int n = 0;
           
            for (int i = 0; i < array.Length-1; i++)
            {
                int count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }

                }
                if (count>maxCount)
                {
                    maxCount = count;
                    n=array[i];
                }
             
            }

            Console.WriteLine("Most friqunced number is [{0}]-->({1} times)",n,maxCount);

        }
    }

