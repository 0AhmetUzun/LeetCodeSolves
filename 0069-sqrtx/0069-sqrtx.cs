public class Solution {
    public int MySqrt(int x) {
        int min = 0;
        int max = x;

        while (min <= max) {
            int mid = (min + max) / 2;
            long square = (long) mid * mid; 

            if (square > x) {
                max = mid - 1;
            } else if (square < x) {
                min = mid + 1;
            } else {
                return mid;
            }
        }
        return max;
    }
}