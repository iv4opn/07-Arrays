using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SumOfSubsetEl
    {
        static void Main()
        {
            //* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
            //  arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

            int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
            Console.WriteLine("Enter the searching sum:");
            int S = int.Parse(Console.ReadLine());
            long searchSum = int.MinValue;
            int variants = (int)Math.Pow(2,array.Length);
            bool flag = false;
            
            for (int i = 0; i < variants; i++)
            {

                for (int bitPossition = 0; bitPossition < array.Length; bitPossition++)
                {
                    if ((i & (1 << bitPossition))!=0)
                    {
                        searchSum+=array[bitPossition];
                    }
                                   
                }
                if (searchSum==S)
                {
                    flag = true; break;
                }
                else
                {
                    searchSum = 0;
                }
                
            }
            if (flag)
            {
                Console.WriteLine("Exists a subset of the elements of the array that has a sum S={0}.",S);
                
            }
            else
            {
                Console.WriteLine("Doesn't exists a subset of the elements of the array that has a sum S.");
            }


        }
    }

