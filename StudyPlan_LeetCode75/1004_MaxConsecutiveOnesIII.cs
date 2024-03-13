/* fi (first index) and li (last index)
 * logic is use all of k to get max consecutive 1
 * when k is below 0, increase fi also to keep li - fi to give the correct answer (longest)
 * if we can find new 1's, we can keep fi same and increase li and maximize the answer
 * return li - fi
 */

public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int fi = 0, li = -1, nl = nums.Length;

        while (++li < nl) 
        {
            if (nums[li] == 0) k--;
            if (k < 0 && nums[fi++] == 0) k++;
        }

        return li - fi;
    }
}