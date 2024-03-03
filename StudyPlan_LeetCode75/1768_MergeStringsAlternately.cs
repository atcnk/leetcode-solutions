/* check if word length is 0, return other word
 * loop through length of shortest word, append chars to answer
 * append remaining chars of longest word if any
 */

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int w1l = word1.Length, w2l = word2.Length;

        if (w1l == 0)
        {
            return word2;
        }

        if (w2l == 0)
        {
            return word1;
        }

        StringBuilder sb = new();
        int i1 = 0, i2 = 0, m = Math.Min(w1l, w2l);

        while (i1 < m)
        {
            sb.Append(word1[i1++]);
            sb.Append(word2[i2++]);
        }

        while (i1 < w1l)
        {
            sb.Append(word1[i1++]);
        }

        while (i2 < w2l)
        {
            sb.Append(word2[i2++]);
        }

        return sb.ToString();
    }
}