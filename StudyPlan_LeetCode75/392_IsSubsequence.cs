/* if length of s is zero, return true 
 * if length of t is zero, there is noting to sub, return false
 * loop trough t, try to find chars of s in order
 * if chars are not the same, continue
 * if subindex is last index, we found subsequence, return true
 * if not increase si 
 * return false if we cant return true in loop
 */

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int sl = s.Length, tl = t.Length;

        if (sl == 0) return true;
        if (tl == 0) return false;

        int i = -1, si = 0;

        while (++i < tl)
        {
            if (t[i] != s[si]) continue;
            if (si == sl - 1) return true;

            si++;
        }

        return false;
    }
}