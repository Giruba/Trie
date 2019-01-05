using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trie!");
            Console.WriteLine("-----");

            Console.WriteLine("Enter the number of strings to be entered in the trie");
            try
            {
                TrieNode root = null;
                Trie trie = null;
                int noOfStrings = int.Parse(Console.ReadLine());
                for (int i = 0; i < noOfStrings; i++)
                {
                    Console.WriteLine("Enter the string");
                    String input = Console.ReadLine();
                    trie = new Trie();
                    root = trie.Insert(input);
                }
                int choice = 0;
                do {                    
                    Console.WriteLine("Enter the string to be searched");
                    String word = Console.ReadLine();
                    trie.Search(root, word);
                    Console.WriteLine("Enter 1 to continue search");
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                    } catch (Exception exception) {
                        Console.WriteLine("Thrown exception is " + exception.Message);
                    }
                } while (choice != 0);
            }
            catch (Exception exception) {
                Console.WriteLine("Exception thrown is "+exception.Message);
            }


            Console.ReadLine();
        }
    }
}
