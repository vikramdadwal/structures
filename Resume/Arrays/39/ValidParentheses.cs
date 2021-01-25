using System.Collections.Generic;
using System.Linq;

namespace Interview.Arrays._39
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public class ValidParentheses
    {
        public static bool HasValidParanthesis(string input)
        {
            Stack<char> charStack = new Stack<char>();

            char[] chars = input.ToCharArray();


            foreach (var character in chars)
            {
                if(character == '[' || character == '(' || character == '{')
                {
                    charStack.Push(character);
                }
                else if(character == ']' && charStack.Any() && charStack.Peek() == '[')
                {
                    charStack.Pop();
                }
                else if (character == ')' && charStack.Any() && charStack.Peek() == '(')
                {
                    charStack.Pop();
                }
                else if (character == '}' && charStack.Any() && charStack.Peek() == '{')
                {
                    charStack.Pop();
                }
            }

            if(!charStack.Any())
            {
                return true;
            }

            return false;
        }
    }
}
