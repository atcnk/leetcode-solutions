/* initialize hashset of vowels
 * initialize stringbuilder (sb) with string s
 * initialize left (l) and right (r) indexes
 * loop if l < r and search vowel for both l and r indexes
 * if l > r, break to prevent searching same indexes again
 * if not, change both vowel chars at l and r indexes
 * continue looping if l < r
 * return sb
 */

public class Solution
{
    public string ReverseVowels(string s)
    {
        var v = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var sb = new StringBuilder(s);
        int l = 0, r = s.Length - 1;

        while (l < r)
        {
            while (!v.Contains(sb[l]) && l < r) l++;
            while (!v.Contains(sb[r]) && r > l) r--;

            if (l > r) break;

            var t = sb[l];
            sb[l++] = sb[r];
            sb[r--] = t;
        }

        return sb.ToString();
    }
}