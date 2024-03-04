/* check if str1 + str2 == str2 + str1
 * if not, there is no common part, return empty string
 * if true, consider strings lengthes as numbers
 * do the math to find gdc for these two numbers
 * substring str1 or str2 with (0, gdc) indexes, return it
 */

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        StringBuilder sb1 = new(str1 + str2);
        StringBuilder sb2 = new(str2 + str1);

        if (!sb1.Equals(sb2))
        {
            return "";
        }

        int n1 = str1.Length, n2 = str2.Length, t;

        while (n2 != 0)
        {
            t = n2;
            n2 = n1 % n2;
            n1 = t;
        }

        return sb1.ToString(0, n1);
    }
}