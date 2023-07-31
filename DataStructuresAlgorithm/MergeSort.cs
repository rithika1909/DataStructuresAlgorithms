using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class MergeSort
    {
        public void SortByMerge(string[] array)
        {
            if (array.Length <= 1)
                return;
            int mid = array.Length / 2;
            string[] left = new string[mid];
            string[] right = new string[array.Length - mid];
            for (int i = 0; i < mid; i++)
                left[i] = array[i];
            for (int i = mid; i < array.Length; i++)
                right[i - mid] = array[i];
            SortByMerge(left);
            SortByMerge(right);
            Merge(array, left, right);
        }
        static void Merge(string[] ar, string[] left, string[] right)
        {
            int leftIndex = 0, rightIndex = 0, currentIndex = 0;
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (string.Compare(left[leftIndex], right[rightIndex]) <= 0)
                    ar[currentIndex++] = left[leftIndex++];
                else
                    ar[currentIndex++] = right[rightIndex++];
            }
            while (leftIndex < left.Length)
                ar[currentIndex++] = left[leftIndex++];
            while (rightIndex < right.Length)
                ar[currentIndex++] = right[rightIndex++];
        }
        public void PrintArray(string[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item + " ");
            Console.WriteLine();
        }

    }
}
