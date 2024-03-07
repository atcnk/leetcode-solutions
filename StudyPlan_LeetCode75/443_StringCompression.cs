/* get first char as lastChar, start loop with index 1
 * if char equals lastChar, counter++ and continue to understand how many time there is that char
 * if not, update lastChar with this char
 * if counter > 1, we need to add this number as char
 * get counter as string, foreach char of string, add to chars array
 * after loop do the same thing in ending of loop
 * return ai because return type is integer but leetcode checks chars array
 */

public class Solution
{
    public int Compress(char[] chars)
    {
        var lc = chars[0];
        int i = 0, ai = 0, c = 1;

        while (++i < chars.Length)
        {
            if (chars[i] == lc)
            {
                c++;
                continue;
            }

            chars[ai++] = lc;

            if (c > 1) UpdateCharsWithCounter(ref ai, ref chars, c.ToString().ToCharArray());

            lc = chars[i];
            c = 1;
        }

        chars[ai++] = lc;

        if (c > 1) UpdateCharsWithCounter(ref ai, ref chars, c.ToString().ToCharArray());

        return ai;
    }

    private void UpdateCharsWithCounter(ref int ai, ref char[] chars, char[] cca)
    {
        foreach (var cc in cca) chars[ai++] = cc;
    }
}