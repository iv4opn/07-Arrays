using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfKElements
{
    static void Main()
    {
        //* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. Find in the array a subset of K elements that have sum S or indicate about its            absence.

        
        int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
        Console.WriteLine("Enter the searching sum:");
        int S = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of K elements who generate the sum S:");
        int K = int.Parse(Console.ReadLine());
        long searchSum = int.MinValue;
        int count = 0;
        int variants = (int)Math.Pow(2, array.Length);
        bool flag = false;

        for (int i = 0; i < variants; i++)
        {

            for (int bitPossition = 0; bitPossition < array.Length; bitPossition++)
            {
                if ((i & (1 << bitPossition)) != 0)
                {
                    searchSum += array[bitPossition];
                    count++;
                }

            }
            if (searchSum == S && count==K)
            {
                flag = true; break;
            }
            else
            {
                count = 0;
                searchSum = 0;
            }

        }
        if (flag)
        {
            Console.WriteLine("Exists a subset of K elements of the array that has a sum S={0}.", S);

        }
        else
        {
            Console.WriteLine("Doesn't exists a subset of K elements of the array that has a sum S.");
        }

    }
}

