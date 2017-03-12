using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortSubArray
{
    static void Main()
    {
       //* Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining           sorted array. Example:
       //  {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

        int[] array = { 7, 4, 9, 2, 0, 456, 11, 1, 999 };
        // List<int> proba = new List<int>(new int[] { 7, 4, 9, 2, 0, 456, 11, 1, 999 });
      
        List<int> sequence = new List<int>();
        int count = 0;
        int findCount = 0;
        int index = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] >= array[i] && array[i]!=0)
                {
                    count++;

                }

            }
            if (count >= findCount)
            {
                findCount = count;
                index = i;
            }
            count = 0;
        }

        sequence.Add(array[index]);
        for (int i = index + 1; i < array.Length; i++)
        {
            if (array[index] < array[i])
            {
                sequence.Add(array[i]);

            }

        }

        for (int i = 0; i < sequence.Count - 1; i++)
        {
            if (sequence[i] > sequence[i + 1])
            {
                sequence.Remove(sequence[i]);
            }

        }

        for (int i = 0; i < sequence.Count; i++)
        {
            Console.WriteLine(sequence[i]);
        }
      
    }
}

