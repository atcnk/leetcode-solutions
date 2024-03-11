/* if nums length (nl) is one, there is no operation, return 0
 * initialize max operations (mo), left and right indexes (li - ri)
 * sort nums and start loop
 * we need to get closer to the number k, if not the same
 * if total is bigger than k, decrease ri, if smaller increase li
 * if equals, do both and increase mo (max operations) because we find the k with these indexes
 * return mo
 */

public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        var nl = nums.Length;

        if (nl == 1) return 0;

        int mo = 0, li = 0, ri = nl - 1;

        Array.Sort(nums);

        while (li < ri)
        {
            var tt = nums[li] + nums[ri];

            if (tt < k)
            {
                li++;
            }
            else if (tt > k)
            {
                ri--;
            }
            else
            {
                mo++;
                li++;
                ri--;
            }
        }

        return mo;
    }
}