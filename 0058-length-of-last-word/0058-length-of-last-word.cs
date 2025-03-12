public class Solution {
    public int LengthOfLastWord(string s) {
        char[] sArray = s.ToCharArray();
        Array.Reverse(sArray);
        string reversedS = new string(sArray);
        
        int length = 0;
        bool wordStarted = false;

        for (int i = 0; i < reversedS.Length; i++) {
            if (reversedS[i] != ' ') 
            {
                length++;
                wordStarted = true;
            } 
            else if(wordStarted) 
            {
                break;
            }
        }
        return length;
    }
}