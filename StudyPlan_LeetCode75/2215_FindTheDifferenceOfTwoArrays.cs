/* solution is creating a new list from nums1 except nums2 numbers and the same for nums2
 * there is except method for arrays, use it and cast to list
 */

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        return new List<IList<int>> { nums1.Except(nums2).ToList(), nums2.Except(nums1).ToList() };
    }
}