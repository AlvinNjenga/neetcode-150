public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indices = new Dictionary<int, int>();
        
        for (var i = 0; i < nums.Length; i++) {
            var num = nums[i];
            var diff = target - num;
            
            if (indices.ContainsKey(diff))
                return new int[] { indices[diff], i };
            
            indices[num] = i;
        }
        
        return new int[0];
    }
}