/* declare sum (s) and maxSum (ms)
 * calculate sum of first k numbers
 * logic is add next number of array and subtract first, like we're swiping
 * start loop from index k, add number at index i and subtract number at index i - k
 * compare if s bigger than ms
 * return ms / k 
 */

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int s = 0, ms = 0, nl = nums.Length;

        for (int i = 0; i < k; i++) s += nums[i];

        ms = s;

        for (int i = k; i < nl; i++)
        {
            s += nums[i] - nums[i - k];
            ms = Math.Max(ms, s);
        }

        return (double)ms / k;
    }
}