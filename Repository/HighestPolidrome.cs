using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.App.HITOPIA.Repository
{
    public class HighestPolidrome
    {
        public string FindHighestPalindrome(string s, int k)
        {
            char[] chars = s.ToCharArray();
            int n = chars.Length;

            // Step 1: Make the string a palindrome with minimal changes
            int minChanges = MakePalindrome(chars, 0, n - 1, k);

            // If we cannot even make it a palindrome within k changes
            if (minChanges == -1)
            {
                return "-1";
            }

            // Step 2: Maximize the palindrome
            MaximizePalindrome(chars, 0, n - 1, k);

            return new string(chars);
        }

        public int MakePalindrome(char[] chars, int left, int right, int k)
        {
            int changes = 0;
            while (left < right)
            {
                if (chars[left] != chars[right])
                {
                    chars[left] = chars[right] = (char)Math.Max(chars[left], chars[right]);
                    changes++;
                }
                left++;
                right--;
            }
            return changes <= k ? changes : -1;
        }

        public void MaximizePalindrome(char[] chars, int left, int right, int k)
        {
            while (left < right && k > 0)
            {
                if (chars[left] != '9')
                {
                    if (chars[left] != chars[right])
                    {
                        // If it was a previous change, we need only 1 change to maximize
                        k -= 1;
                    }
                    else
                    {
                        // If it was not a previous change, we need 2 changes to maximize
                        k -= 2;
                    }
                    if (k >= 0)
                    {
                        chars[left] = chars[right] = '9';
                    }
                }
                left++;
                right--;
            }
        }
    }
}
