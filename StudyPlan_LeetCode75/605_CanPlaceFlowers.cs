/* (length of flowerbed + 1) / 2 is the max num of flowers can planted, if n is bigger than that, return false
 * if n is zero, there are no new flowers to plant, return true
 * loop through array with index i, check if flowerbed[i] is empty && prev bed && next bed. at the same time check if i is first or last index to prevent index out of range error
 * if all is empty, set 1 at index i and i++ since we cant plant next index and we have planted 1 so n--
 * if n is zero, we have planted all, return true
 * if not, return false
 */

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var fl = flowerbed.Length;

        if (n > (fl + 1) / 2) return false;
        if (n == 0) return true;

        for (int i = 0; i < fl; i++)
        {
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == fl - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i++] = 1;
                n--;
            }

            if (n <= 0) return true;
        }

        return false;
    }
}