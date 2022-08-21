public class Solution {
    public bool IsPalindrome(string s) {
        var formattedInput = s.ToLower().Where(ch => Char.IsLetterOrDigit(ch)).ToArray();
        
        var headIndex = 0;
        var tail = formattedInput.Count() - 1;
            
        while (headIndex <= tail) {
            if (formattedInput[headIndex] != formattedInput[tail]) return false;
            
            headIndex++;
			tail--;
        }
        
        return true;
    }
}