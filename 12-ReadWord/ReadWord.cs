using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ReadWord
    {
        static void Main()
        {
            //Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.


            char[] alphabet = new char[26];
            Console.WriteLine("Enter the word:");
            string word = Console.ReadLine();
            List<int> index = new List<int>();
            
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = Convert.ToChar('A' + i);
            }

            
            for (int i = 0; i < word.Length; i++)
            {
               
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if ( char.ToUpper(word[i])==alphabet[j])
                    {

                        index.Add(j); break;
                    }
                }
                
                
            }
            


            Console.Write("The aphpabetic indeces of word [{0}] are:", word.ToUpper() );
            for (int i = 0; i < index.Count; i++)
            {
                Console.Write(" " + index[i]);
            }
            Console.WriteLine();
           
        }
    }

