using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SelectionSortArray
    {
        static void Main()
        {
            //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the                first position, find the smallest from the rest, move it at the second position, etc.

            Console.WriteLine("Enter number of the array elements:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j]<array[i])
                    {
                        array[i] ^= array[j];
                        array[j] ^= array[i];
                        array[i] ^= array[j];
                    }
                    
                }
               
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

