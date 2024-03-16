/* if nl (nums.Lenght) is 1, ls (left sum) and rs (right sum) are 0, return 0 (index)
 * when index is 0, ls is zero because there is no num on left side
 * rs is sum of array - first index (index 0)
 * if ls = rs return 0 (index)
 * if not start looping, subtract number of index from rs and add number of index - 1 to ls
 * check ls = rs again, return index this time 
 */

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int nl = nums.Length;

        if (nl == 1) return 0;

        int i = 0, ls = 0, rs = nums.Sum() - nums[0];

        if (ls == rs) return 0;

        while (++i < nl)
        {
            rs -= nums[i];
            ls += nums[i - 1];

            if (ls == rs) return i;
        }

        return -1;
    }
}