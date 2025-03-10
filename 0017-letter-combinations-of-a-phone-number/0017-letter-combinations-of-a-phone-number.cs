public class Solution {
    public IList<string> LetterCombinations(string digits) {
        
        Dictionary<int, string> numberToLetters = new Dictionary<int, string>
        {
            {2, "abc"},
            {3, "def"},
            {4, "ghi"},
            {5, "jkl"},
            {6, "mno"},
            {7, "pqrs"},
            {8, "tuv"},
            {9, "wxyz"}
        };

        List<string> result = new List<string>();
        if (string.IsNullOrEmpty(digits))
        {
            return result;
        }
        else
        {
            result.Add("");
            foreach (char index in digits)
            {
                if (numberToLetters.ContainsKey(index - '0'))
                {
                    List<string> temp = new List<string>();
                    string letters = numberToLetters[index - '0'];
                    foreach (string combination in result)
                    {
                        foreach (char letter in letters)
                        {
                            temp.Add(combination + letter);
                        }
                    }
                    result = temp;
                }
            }
            return result;
        }    
    }    
}