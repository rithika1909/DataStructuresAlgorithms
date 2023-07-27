using System;
namespace DataStructuresAlgorithm
{
    class program
    {
        static string FilePath = @"D:\DataStructuresAlgorithm\Files\Search.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Option:\n 1.Binary Search\n 2. Anagram\n 3.Replace String\n 4. Insertion Sort\n 5.Exit");
            
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
                        flag = false;
                        break;
                }
            }

           
            
        }
    }
}
