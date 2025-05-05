namespace Assignment_5._1._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };

        }

        public static bool CheckNums(int[] nums)
        {
            foreach (int i in nums)
            {
                while (i > nums.Length)
                {
                    if (i == i + 1)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
