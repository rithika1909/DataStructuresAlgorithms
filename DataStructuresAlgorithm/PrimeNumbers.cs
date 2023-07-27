using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class PrimeNumbers
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
    }
}
    



