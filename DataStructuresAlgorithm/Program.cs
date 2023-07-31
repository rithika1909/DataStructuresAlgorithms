using System;
namespace DataStructuresAlgorithm
{
    class program
    {
        static string FilePath = @"D:\DataStructuresAlgorithm\Files\Search.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Option:\n 1.Binary Search\n 2.Anagram\n 3.Replace String\n 4.Insertion Sort\n 5.Bubble Sort\n 6.Prime Numbers\n 7.Check Prime as both Anagram and palindrome\n 8.Exit");
            bool flag = true;
            while(flag) 
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) 
                {

                    case 1:
                        BinarySearch search = new BinarySearch();
                        Console.WriteLine("Enter Element to search");
                        search.ReadAllTextFileAndSearch(FilePath);
                        break;
                    case 2:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram();
                        break;
                    case 3:
                        ReplaceString replaceString = new ReplaceString();
                        replaceString.StringReplace();
                        break;
                    case 4:
                        InsertionSort sort = new InsertionSort();
                        Console.WriteLine("Enter a list of words:");
                        string input = Console.ReadLine();
                        string[] words = input.Split(new char[] { ' ' });
                        sort.SortArray(words);
                        Console.WriteLine("Sorted List:");
                        Console.WriteLine(string.Join(" ", words));
                        break;
                    case 5:
                        BubbleSort bubbleSort   = new BubbleSort();
                        bubbleSort.SortByBubble();
                        break;
                    case 6:
                        PrimeNumbers primeNumbers = new PrimeNumbers();
                        primeNumbers.CheckforPrime();
                        break;
                    case 7:
                        PrimeNumbers primeNumbers1 = new PrimeNumbers();
                        AnagramAndPalindrome anagramAndPalindrome = new AnagramAndPalindrome();
                       
                        primeNumbers1.CheckforPrime();
                        anagramAndPalindrome.FindPrimeAnagramPalindromeNumbers();
                        break;
                    case 8:
                        MergeSort mergeSort = new MergeSort();
                        Console.WriteLine("Enter the limit:");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the strings:");
                        string[] array1 = new string[n1];
                        for (int i = 0; i < n1; i++)
                        {
                            array1[i] = Console.ReadLine();
                        }
                        mergeSort.SortByMerge(array1);
                        Console.WriteLine("\nSorted Array:");
                        mergeSort.PrintArray(array1);
                        break;

                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}
