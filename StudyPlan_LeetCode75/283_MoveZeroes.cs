/* initialize index of first zero (fzi)
 * we need to change first non zero number with first zero number
 * loop through nums array, if num is zero continue
 * if not, check if we're at fzi, increase fzi and continue
 * if not, change the num with num at fzi
 */

class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int i = -1, fzi = 0; // index of first zero

        while (++i < nums.length)
        {
            if (nums[i] == 0) continue;

            if (i == fzi)
            {
                fzi++;
                continue;
            }

            nums[fzi++] = nums[i];
            nums[i] = 0;
        }
    }
}