namespace DSA.Questions_and_Solutios
{
    public class PrintTwoIndexEqualToSum
    {
        public int[] TwoSum(int[] Array, int target)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] + Array[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[] {};
        }
    }
}
