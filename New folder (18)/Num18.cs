using System;

namespace Assingment
{
    public class Num18
    {
        public static void checkifthefirstelementandthelastelementareequal()
        {
            int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
     
            Console.WriteLine((nums1[0].Equals(nums1[nums1.Length - 1])));
        }
    }
}
