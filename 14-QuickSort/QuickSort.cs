using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class QuickSorting
    {
        static int Part(int[] arrays, int start, int end)
        {
           //Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

            
            int pivot = arrays[end]; 
            int index = start;

            for (int i = start; i < end; i++)
            {
                if (arrays[i] <= pivot)
                {
                    if (i == index) 
                    {
                        index++;
                        continue;
                    }
                    arrays[i] ^= arrays[index]; 
                    arrays[index] ^= arrays[i];
                    arrays[i] ^= arrays[index];
                    index++;
                }
            }
            if (end == index) 
            {
                return index;
            }
            else
            {

                arrays[end] ^= arrays[index]; 
                arrays[index] ^= arrays[end];
                arrays[end] ^= arrays[index];
                return index;
            }
        }

        static void QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = Part(array, start, end);
                QuickSort(array, start, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, end);
            }
        }

        static void Main()
        {
            string text = Console.ReadLine();
            int[] arrays = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                arrays[i] = Convert.ToInt32(text[i]);
            }

            QuickSort(arrays, 0, (arrays.Length - 1));

            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine(Convert.ToChar(arrays[i]));
            }
        }
    }

