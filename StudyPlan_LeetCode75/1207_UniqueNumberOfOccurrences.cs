/* initialize occurences array (o) with 2001 size (max leetcode input)
 * initialize bool array (b) 
 * loop through arr increase the number at that index (n)
 * we try to get count of occurrences for every number with array o
 * after that we loop through array o, if occurence number (n) is zero it means there is no occurence, continue
 * then we check bool array b. with this array we try to log true if there is a number that occures n time 
 * if we found that there is more than one number that occures same time, return false
 * after loop it means all number counts are unique, return true
 */

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var o = new int[2001];
        var b = new bool[arr.Length + 1];

        foreach (var n in arr)
        {
            o[n + 1000] += 1;
        }

        foreach (var n in o)
        {
            if (n == 0) continue;
            if (b[n]) return false;

            b[n] = true;
        }

        return true;
    }
}