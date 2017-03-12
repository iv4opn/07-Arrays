using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MaxSumOfK

    {
        static void Main()
        {
            //Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

            Console.WriteLine("Eneter number N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Eneter number K:");
            int k = int.Parse(Console.ReadLine());
            int[] array=new int[n];
            int searchSum = 0;
            int findSum = int.MinValue;
            int index = 0;
            int j = 0;

            if (k < n)
            {
            Console.WriteLine("Eneter elements:");
            for (int i = 0; i <array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
                for (int i = 0; i <=array.Length-k; i++)
                {
                    for (j = i; j <k+i; j++)
                    {
                        searchSum += array[j];
                        
                    }
                    if (searchSum>findSum)
                    {
                        findSum = searchSum;
                        index=j-k;
                        
                    }

                    searchSum = 0;
                }
                Console.Write("Maximal sum is {0}, between index:\n",findSum);
                for (int i = index; i < index + k; i++)
                {
                    Console.WriteLine("[{0}]={1}",i, array[i]);
                }
                
            }
            else
	        {
                Console.WriteLine("'N' must bigger than 'K'");
                
	        }

            
        }
    }

