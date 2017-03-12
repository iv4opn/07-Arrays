using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MultiArrayIndex
    {
        static void Main()
        {
            //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.


            Console.WriteLine("Enter number of the array elements:");   
            byte n = byte.Parse(Console.ReadLine());
            int[] array=new int[n];            
            for (int i = 0; i < array.Length; i++)
            {
            
                array[i] = i*5;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Index {0} x 5 is= {1}", i, array[i]);
            }

        }
    }


