/* create vs (vowels string) - vn (temp vowel number) - mvn (max vowel number)
 * loop through first k numbers of s and calculate number of vowels
 * if mvn is already equals k, no need to check other chars, return mvn
 * if not, loop through string s with k as a starting index
 * consider like window that has max 3 chars and slide it to right
 * if new char is vowel, increase vn
 * if old char is vowel, decrease vn
 * if vn is smaller than mvn, continue
 * if vn is already equals to k, return vn, no need to check other chars
 * if not vn is bigger than mvn, set mvn to vn
 * return mvn
 */

public class Solution
{
    public int MaxVowels(string s, int k)
    {
        string vs = "aeiouAEIOU";
        int mvn, vn = 0, sl = s.Length;

        for (int i = 0; i < k; i++)
        {
            if (!vs.Contains(s[i])) continue;

            vn++;
        }

        mvn = vn;

        if (mvn == k) return mvn;

        for (int i = k; i < sl; i++)
        {
            if (vs.Contains(s[i])) vn++;
            if (vs.Contains(s[i - k])) vn--;
            if (vn <= mvn) continue;
            if (vn == k) return vn;

            mvn = vn;
        }

        return mvn;
    }
}