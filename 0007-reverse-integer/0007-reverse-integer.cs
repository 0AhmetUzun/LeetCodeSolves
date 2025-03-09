public class Solution {
    public int Reverse(int x) {
        try {
            char[] charX = (x.ToString()).ToCharArray();
                
            if (x < 0) {
                string positiveX = Math.Abs(x).ToString(); 
                char[] numberArray = positiveX.ToCharArray(); 
                Array.Reverse(numberArray); 
                string reversedPositiveX = new string(numberArray);                         
                int result = int.Parse("-" + reversedPositiveX);
                return result;
            } else {
                for (int i = 0; i < charX.Length / 2; i++) {
                    char temp = charX[i];
                    charX[i] = charX[charX.Length - 1 - i];
                    charX[charX.Length - 1 - i] = temp;
                }
                int result = int.Parse(string.Join("", charX));
                return result;
            }
        } catch (OverflowException) {
            return 0; 
        }
    }
}