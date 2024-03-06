/* loop string sl (string length) 
 * if char is not space, add to w (word), continue
 * if not, check if w length is zero, continue
 * if not insert space and w to rw (reverse words), clear word
 * after loop, if w length is not zero, also insert that w to rw
 * decrease rw length to clear space at the end of the rw string
 * return rw
 */

public class Solution
{
    public string ReverseWords(string s)
    {
        var rw = new StringBuilder();
        var w = new StringBuilder();
        var sl = s.Length;

        for (int i = 0; i < sl; i++)
        {
            if (s[i] != ' ')
            {
                w.Append(s[i]);
                continue;
            }

            if (w.Length == 0) continue;

            rw.Insert(0, ' ');
            rw.Insert(0, w);
            w.Clear();
        }

        if (w.Length != 0)
        {
            rw.Insert(0, ' ');
            rw.Insert(0, w);
        }

        rw.Length--;

        return rw.ToString();
    }
}