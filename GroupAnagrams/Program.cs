using System;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var solution = new Solution();
            solution.GroupAnagrams(strs);
        }
    }
}
