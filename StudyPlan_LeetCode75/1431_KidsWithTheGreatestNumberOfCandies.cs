/* find greatest candie number in candies array
 * loop through array, select if (candie + extra candie) >= (greatest candie)
 * convert selected items to list and return
 */

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int gc = candies.Max();

        return candies.Select(c => (c + extraCandies) >= gc).ToList();
    }
}