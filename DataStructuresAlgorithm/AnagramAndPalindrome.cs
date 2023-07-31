using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class AnagramAndPalindrome
    {
        public void CheckforPrime()
        {
            Console.WriteLine("Prime numbers between 0 and 1000 Are :");
            for (int num = 2; num <= 1000; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(num + " ");
                }
            }

        }
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public bool AreAnagrams(int num1, int num2)
        {
            char[] arr1 = num1.ToString().ToCharArray();
            char[] arr2 = num2.ToString().ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            return new string(arr1)==new string(arr2);
        }

        public bool IsPalindrome(int number)
        {
            string numStr = number.ToString();
            int left = 0;
            int right = numStr.Length - 1;

            while (left < right)
            {
                if (numStr[left] != numStr[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        public void FindPrimeAnagramPalindromeNumbers()
        {
            Console.WriteLine("\nPrime numbers that are Anagrams and Palindromes:");
            List<int> primeAnagramPalindromeNumbers = new List<int>();
            for (int num = 2; num <= 1000; num++)
            {
                if (IsPrime(num) && IsPalindrome(num))
                {
                    for (int otherNum = num + 1; otherNum <= 1000; otherNum++)
                    {
                        if (IsPrime(otherNum) && AreAnagrams(num, otherNum))
                        {
                            primeAnagramPalindromeNumbers.Add(num);
                            
                            break;
                        }
                    }
                }
            }

            foreach (var number in primeAnagramPalindromeNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
