using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TrieImplementaion
{
    public class Node{
        
        public char ch {get;set;}
        public Node[] child {get;set;}
        public bool isWord {get;set;}
        
        public Node(char c){
            this.ch = c;
            this.child = new Node[26];
        }
    }
    public class Trie{
        
        private Node root;
        
        public Trie(){
            root = new Node('\0');
        }
        
        public void insert(string word){
            Node curr = root;
            foreach(var c in word){
                if(curr.child[c-'a'] == null)
                    curr.child[c-'a'] = new Node(c);
                curr = curr.child[c-'a'];
            }
            curr.isWord = true;
        }
        public bool isPrefix(string word){
            return getNode(word) != null;
        }
        public bool search(string word){
            Node node = getNode(word);
            return node != null && node.isWord;
        }
        
        public Node getNode(string word){
            Node curr = root;
            foreach(var c in word){
                if(curr.child[c-'a'] == null)return null;
                curr = curr.child[c-'a'];
            }
            return curr;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.insert("abc");
            Console.WriteLine($"Searching abc.... result {trie.search("abc")}");
            trie.insert("cab");
            Console.WriteLine($"Searching cab.... result {trie.search("cab")}");
            Console.WriteLine($"Searching aab.... result {trie.search("aab")}");
            Console.WriteLine($"ab prefix.... result {trie.isPrefix("ab")}");
            Console.WriteLine($"aa prefix.... result {trie.isPrefix("aa")}");
        }
    }
}