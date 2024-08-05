using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.App.HITOPIA.Repository
{
    public class BalancedBraket
    {
        public string IsBalanced(string input)
        {
            var stack = new Stack<char>();
            var matchingBrackets = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != matchingBrackets[ch])
                    {
                        return "NO";
                    }
                }
            }
            return stack.Count == 0 ? "YES" : "NO";
        }
    }
}
