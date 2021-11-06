using System;
using System.Collections.Generic;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var strs = new List<string>{ "aabb", "abcd", "bbaa", "dada" };

            Solution.Anagrams("abba", strs);
        }
    }
}
