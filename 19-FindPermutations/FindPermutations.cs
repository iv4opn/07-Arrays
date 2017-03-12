using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FindPermutations
{
    public static void Main(string[] args)
    {
        //* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
        //  n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

        
        int n = int.Parse(Console.ReadLine());
        int startOfRange = (int)Math.Pow(10, n - 1);
        int endOfRange = (n + 1) * startOfRange;
        Console.WriteLine("{0} {1}", startOfRange,endOfRange);
        for (int i = startOfRange; i < endOfRange; i++)
        {
            if (IsNumberContainsDigitsFromRange(i, n))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsNumberContainsDigitsFromRange(int number, int range)
    {
        bool isNumberContainsGivenDigits = true;
        string numberAsString = Convert.ToString(number);
        for (int i = 1; i <= range; i++)
        {
            if (!(numberAsString.Contains(Convert.ToString(i))))
            {
                isNumberContainsGivenDigits = false;
            }
        }
        return isNumberContainsGivenDigits;
    }


}

