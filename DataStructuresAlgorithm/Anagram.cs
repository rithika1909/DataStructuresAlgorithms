using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter 2 strings");
            string word1 = Console.ReadLine();
            char[] char1 = word1.ToCharArray();
            Array.Sort(char1);
            string word2 = Console.ReadLine();
            char[] char2 = word2.ToCharArray();
            Array.Sort(char2);
            int count = 0;
            if(char1.Length.Equals(char2.Length))
            {
                for(int i=0;i<char1.Length; i++)
                {
                    if (char1[i].Equals(char2[i]))
                    {
                        count++;
                    }

                }
                if (char1.Length.Equals(count))
                    Console.WriteLine("Given Strings are Anagram");
                else
                    Console.WriteLine("Given Strings are not an Anagram");
            }
            else
            {
                Console.WriteLine("Given Strings are not an Anagram");
            }

        }
    }
}
