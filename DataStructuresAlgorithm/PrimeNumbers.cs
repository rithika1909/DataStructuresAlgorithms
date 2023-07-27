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
            bool isPrimeNo = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrimeNo = false;
                        break;
                    }
                }
                if (isPrimeNo)
                {
                    Console.Write("\t" + i);
                }
                isPrimeNo = true;
            }
        }
    }
}
