namespace Assignment_5._1._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };

        }

        static bool CheckNums(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int i in nums)
            {
                if (set.Contains(i)) return true;
                else set.Add(i);
            }
            return false;
        }

        //    foreach (int i in nums)
        //    {
        //        while (i > nums.Length)
        //        {
        //            if (i == i + 1)
        //            {
        //                return true;
        //            }

        //            else
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //}
    }
}
