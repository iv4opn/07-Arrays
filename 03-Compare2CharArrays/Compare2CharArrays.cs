using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Compare2CharArrays
    {
        static void Main()
        {           
            //Write a program that compares two char arrays lexicographically (letter by letter).

            Console.WriteLine("Enter the size of firts  array:");
            int firstArraySize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the firts  array:");
            int secondArraySize = int.Parse(Console.ReadLine());
            char [] firstArray =  new char[firstArraySize];
            char [] secondArray = new char[secondArraySize];
            bool compare = false;

            if (firstArraySize == secondArraySize)
            {
                compare = true;
                Console.WriteLine("Enter the elements of the first  array:");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    firstArray[i] = char.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter the elements of the second array:");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    secondArray[i] = char.Parse(Console.ReadLine());
                }
                if (compare)
                {
                    for (int i = 0; i < firstArray.Length; i++)
                    {
                        if (firstArray[i] != secondArray[i])
                        {
                            compare = false;
                            break;
                        }
                        else
                        {
                            compare = true;
                        }
                    }

                    Console.WriteLine(compare == true ? "The arrays are identical." : "The arrays aren't identical.");
                }

            }
            else
            {
                Console.WriteLine("The arrays aren't identical.");
            }

        }
    }

