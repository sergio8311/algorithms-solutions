using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();
            var groupDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var orderedCurrent = string.Concat(strs[i].OrderBy(c => c));

                if (!groupDict.ContainsKey(orderedCurrent))
                    groupDict.Add(orderedCurrent, new List<string> { strs[i] });

                else
                    groupDict[orderedCurrent].Add(strs[i]);
            }
            result.AddRange(groupDict.Values);
            return result;
        }
    }
}
