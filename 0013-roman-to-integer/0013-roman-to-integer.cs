public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romans = new Dictionary<char, int> 
        {

            {'I', 1},

            {'V', 5},

            {'X', 10},

            {'L', 50},

            {'C', 100},

            {'D', 500},

            {'M', 1000}

        };

        int result = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--) 
        {

            int value = romans[s[i]];

            if (value < prevValue)
            {
                result -= value;
            }
            else
            {
                result += value;
                prevValue = value;
            }
        }

        return result;
        
    }
}