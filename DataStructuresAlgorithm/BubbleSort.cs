using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class BubbleSort
    {
        public void SortByBubble()
        {
            Console.WriteLine("Enter array size: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements: ");
            int[] array= new int[n];
            for(int i=0;i<array.Length;i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());  
            }
            int key;
            for(int j=0;j<=n-2;j++)

            {
                for(int i=0;i<=n-2;i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        key = array[i + 1];
                        array[i+1]= array[i];
                        array[i] = key;

                    }

                }
                
            }
            Console.WriteLine("Sorted: ");
            foreach(var data in array)
                Console.WriteLine(data +" ");

            
        }
        
    }
}
