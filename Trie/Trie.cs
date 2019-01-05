using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    class Trie
    {
        TrieNode root;

        public void SetRoot(TrieNode trieNode) {
            root = trieNode;
        }

        public TrieNode GetRoot() {
            return root;
        }


        public TrieNode Insert(String word) {
            if (root == null) {
                root = new TrieNode();
            }

            word = word.ToLower();
            char[] charArray = word.ToCharArray();
            TrieNode[] children = new TrieNode[26];
            for (int i = 0; i < word.Length; i++) {
                int index = charArray[i] - 'a';
                if (root.GetChildren() == null) {
                    root.SetChildren(children);
                }
                if (children[index] == null)
                {
                    children[index] = new TrieNode();
                }
                else {
                    root = children[index];
                }
            }
            root.SetEndOfWord(true);
            root.SetChildren(children);

            return root;
        }


        public void Search(TrieNode trieNode, String word) {
                String prefix = string.Empty;
                word = word.ToLower();
                char[] array = word.ToCharArray();
                TrieNode[] trieNodes = trieNode.GetChildren();
                for (int i = 0; i < word.Length; i++) {
                    prefix += array[i];
                    int index = array[i] - 'a';
                    if (trieNodes[index] == null)
                    {
                        Console.WriteLine("Entered word is not found!");
                        Console.WriteLine("The prefix found is " + prefix.Substring(0, prefix.Length - 1));
                        return;
                    }
                    else {
                        root = trieNodes[index];
                    }
                }

            
            Console.WriteLine("Entered word "+word+" is found!");
        }
    }
}