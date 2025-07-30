
using System.Collections.Generic;


namespace Assignment10_ADV
{
    public class Balanced
    {

        public  static string IsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> matchingBrackets = new Dictionary<char, char>
            {

            {')', '('},
            {']', '['},
            {'}', '{'}

            };

            foreach (char ch in expression)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != matchingBrackets[ch])
                    {
                        return "Not Balanced";
                    }
                }
            }

            return stack.Count == 0 ? "Balanced" : "Not Balanced";
        }
    }
}
