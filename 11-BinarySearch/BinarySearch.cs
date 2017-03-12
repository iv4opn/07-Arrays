using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinarySearch
    {
        static void Main()
        {
            //Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

            Console.WriteLine("Enter number of array elelments:");
            int n = int.Parse(Console.ReadLine());
            int[]array=new int[n];
            Random rnd = new Random();            
            int index = int.MinValue;
            bool flag =false;
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1,101);
            }
            Array.Sort(array);
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Enter search element:");     
            int value = int.Parse(Console.ReadLine());
            int left =0;
            int right = array.Length;

            while (left <= right && !flag )
                {
                    int middle = (left + right) / 2;   
                    if (array[middle] == value)
                    {
                        index = middle;
                        flag = true;
                    }
                    else if (array[middle] > value)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
           
             Console.WriteLine(flag==true? "Index of element is: " + index : "Enetered wrong element !");
        }
    }

