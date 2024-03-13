/* check the answer of 1004. Max Consecutive Ones III problem
 * this problem has same logic, there are two differences 
 * first difference is k is constant and its 1
 * second difference is we delete 1 element, so we need to decrease answer 
 * consider like this and read the other answer
 */

public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int k = 1, fi = 0, li = -1, nl = nums.Length;

        while (++li < nl)
        {
            if (nums[li] == 0) k--;
            if (k < 0 && nums[fi++] == 0) k++;
        }

        return li - fi - 1;
    }
}