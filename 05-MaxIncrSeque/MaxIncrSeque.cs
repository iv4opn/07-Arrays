using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaxIncrSeque
    {
        static void Main()
        {
            //Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

            Console.WriteLine("Enter number of the array elements:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int serachIndx = 0;
            int startIndx = 0;
            int br = 0;
            int br2 = 0;


            Console.WriteLine("Enter the elements of the  array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i + 1] - array[i]) == 1)
                {
                    br++;
                    serachIndx = i - (br - 1);
                    if (br > br2)
                    {
                        br2 = br;
                        startIndx = serachIndx;
                    }
                }
                else
                {
                    br = 0;
                }
            }
            Console.Write("Maximal increasing sequence is numbers between index [{0}] and [{1}]:", startIndx, (startIndx + br2));
            for (int i = startIndx; i < startIndx + br2 + 1; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }
    }

