using System;
namespace DataStructuresAlgorithm
{
    class program
    {
        static string FilePath = @"D:\DataStructuresAlgorithm\Files\Search.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Option:\n 1.Binary Search\n 2.Exit");
            
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
                        flag = false;
                        break;
                }
            }

           
            
        }
    }
}
