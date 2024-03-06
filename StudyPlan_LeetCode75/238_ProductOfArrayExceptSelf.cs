/* in general, calculate left product then right product without including nums[i]
 * when left product is calculated, we find answer of last index
 * then start right product, last index to first index
 * in right product we store integer c to store product continually
 * return r array
 */

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int c = 1, i = 0, nl = nums.Length;
        var r = new int[nl];

        r[0] = 1;
        r[^1] = 1;

        while (++i < nl) r[i] = r[i - 1] * nums[i - 1];

        while (--i > -1)
        {
            r[i] *= c;
            c *= nums[i];
        }

        return r;
    }
}