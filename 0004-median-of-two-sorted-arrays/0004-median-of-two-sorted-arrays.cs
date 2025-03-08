public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        int[] newArray = new int[nums1.Length + nums2.Length];
        Array.Copy(nums1, newArray, nums1.Length);
        Array.Copy(nums2, 0, newArray, nums1.Length, nums2.Length);

        Array.Sort(newArray);

        if (newArray.Length % 2 == 0) {
            int middle1 = newArray[newArray.Length / 2 - 1];
            int middle2 = newArray[newArray.Length / 2];
            return (middle1 + middle2) / 2.0;
        } else {
            return newArray[newArray.Length / 2];
        }
    }
}
