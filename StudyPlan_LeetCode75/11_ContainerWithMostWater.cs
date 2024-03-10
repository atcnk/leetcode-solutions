/* declare hl for height.Length
 * min hl input is 2, if 2, area will min of indexes because width is 1
 * ma for max area, li for left index (0) and ri for right index (last index)
 * in general, loop and decrease ri and increase li to find max area
 * for container, width is ri - li, height is min of li and ri.
 * we need min because water will spill on side with min length
 * increase li if height[li] is lower, decrease ri if height[ri] is lower, make numbers get closer to each other
 * return ma
 */

public class Solution
{
    public int MaxArea(int[] height)
    {
        var hl = height.Length;

        if (hl == 2)  return Math.Min(height[0], height[1]);

        int ma = 0, li = 0, ri = hl - 1;

        while (li < ri)
        {
            ma = Math.Max(ma, (ri - li) * Math.Min(height[li], height[ri]));

            if (height[li] < height[ri])
            {
                li++;
                continue;
            }

            ri--;
        }

        return ma;
    }
}