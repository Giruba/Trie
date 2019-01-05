using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    class TrieNode
    {
        bool endOfWord;
        TrieNode[] children;


        public void SetEndOfWord(bool value) {
            endOfWord = value;
        }

        public void SetChildren(TrieNode[] children) {
            this.children = children;
        }

        public bool GetEndOfWord() {
            return endOfWord;
        }

        public TrieNode[] GetChildren() {
            return children;
        }
    }
}
