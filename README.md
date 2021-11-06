# algorithms-solutions
Solutions for some algorithms from LeetCode or Code Wars

### Group Anagrams
Given an array of strings strs, group the anagrams together. You can return the answer in any order.
#### Solution
```c#
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
```

### Where my anagrams at?
Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:
```ruby
anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']
```
#### Solution
```c#
public static List<string> Anagrams(string word, List<string> words)
  {
    var orderedWord = string.Concat(word.OrderBy(c => c));
    var result = words.Where(x => string.Concat(x.OrderBy(c => c)) == orderedWord).ToList();
    return result;
  }
```
