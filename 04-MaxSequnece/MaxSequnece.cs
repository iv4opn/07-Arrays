using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaxSequnece
    {
        static void Main()
        {
            //Write a program that finds the maximal sequence of equal elements in an array.
            //Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

            Console.WriteLine("Enter number of the array elements:");
            int n = int.Parse(Console.ReadLine());
            int [] array=new int[n];
            int serachIndx = 0;
            int startIndx = 0;
            int br = 0;
            int br2=0;


            Console.WriteLine("Enter the elements of the first  array:");
            for (int i = 0; i < array.Length; i++)
            {
               array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i]==array[i+1])
                {
                    br++;
                    serachIndx = i - (br-1);
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
            Console.Write("Maximal sequence is numbers with star index [{0}] to [{1}]:", startIndx,(startIndx+br2));
            for (int i = startIndx; i < startIndx+br2+1; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }
    }

