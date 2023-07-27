using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class InsertionSort
    {
        public void SortArray(string[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                string key = array[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(key, array[j])<0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}
