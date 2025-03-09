using System;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums); 
        IList<IList<int>> result = new List<IList<int>>();
        
        for (int i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            
            int nextIndex = i + 1;
            int lastIndex = nums.Length - 1;
            
            while (nextIndex < lastIndex) {
                int sum = nums[i] + nums[nextIndex] + nums[lastIndex];
                
                if (sum == 0) 
                {
                    result.Add(new List<int> { nums[i], nums[nextIndex], nums[lastIndex] });
                    
                    while (nextIndex < lastIndex && nums[nextIndex] == nums[nextIndex + 1]) nextIndex++; 
                    while (nextIndex < lastIndex && nums[lastIndex] == nums[lastIndex - 1]) lastIndex--; 
                    
                    nextIndex++;
                    lastIndex--;
                } 
                else if (sum < 0) 
                {
                    nextIndex++;
                } 
                else 
                {
                    lastIndex--;
                }
            }
        }  
        return result;
    }
}