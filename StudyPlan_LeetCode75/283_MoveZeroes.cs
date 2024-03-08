class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int index = -1;
        int firstIndexOfZero = 0;

        while (++index < nums.length)
        {
            if (nums[index] == 0) continue;

            if (index == firstIndexOfZero)
            {
                firstIndexOfZero++;
                continue;
            }

            nums[firstIndexOfZero++] = nums[index];
            nums[index] = 0;
        }
    }
}