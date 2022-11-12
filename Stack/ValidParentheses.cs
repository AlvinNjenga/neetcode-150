public class Solution
{
    public bool IsValid(string s)
    {
        var bracketStack = new Stack<Char>();

        foreach (var character in s)
        {
            if (IsOpeningBracket(character))
            {
                bracketStack.Push(character);
                continue;
            }
            else if (IsClosingBracket(character))
            {
                if (bracketStack.Count <= 0) return false;

                var lastBracket = bracketStack.Pop();

                if (!IsMatchingBracket(lastBracket, character))
                    return false;
            }
        }

        return bracketStack.Count == 0;
    }

    public bool IsOpeningBracket(Char character) => (new List<Char> { '(', '[', '{' }).Contains(character);

    public bool IsClosingBracket(Char character) => (new List<Char> { ')', ']', '}' }).Contains(character);

    public bool IsMatchingBracket(Char openingBracket, Char closingBracket)
    {
        if (openingBracket == '(') return closingBracket == ')';
        if (openingBracket == '{') return closingBracket == '}';
        if (openingBracket == '[') return closingBracket == ']';

        return false;
    }
}

// Comments

// You had the solution down, but could have made this a more succinct if you paid attention and realised
// that you could only have parantheses as inputs. Also, an invalid amount (odd) would be a quick
// instant way to crash out, which is logical.