/* if nums length <= 2 its impossible to i < j < k exist, return false
 * let integer f (first) and s (second) to be max value
 * loop through nums
 * compare first f then s with the number, if n <= assign it
 * if there something like n > f and n > s then we have f < s < n, return true
 * if not return false
 */

public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length <= 2) return false;

        int f = Int32.MaxValue, s = f;

        foreach (var n in nums)
        {
            if (n <= f)
            {
                f = n;
            }
            else if (n <= s)
            {
                s = n;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}