/* update a (altitude) every time 
 * check if a is bigger than ma (max altitude)
 * return ma
 */

public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        int a = 0, ma = 0, i = -1, gl = gain.Length;

        while (++i < gl)
        {
            a += gain[i];

            if (a <= ma)
            {
                continue;
            }

            ma = a;
        }

        return ma;
    }
}