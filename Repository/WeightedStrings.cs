using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.App.HITOPIA.Repository
{
    public class WeightedStrings
    {

        public int CalculateWeight(string s)
        {
            int weight = 0;
            foreach (char c in s)
            {
                weight += c - 'a' + 1;
            }
            return weight;
        }

        public List<string> SplitConsecutiveCharacters(string s)
        {
            var substrings = new List<string>();
            if (string.IsNullOrEmpty(s))
            {
                return substrings;
            }

            char previousChar = s[0];
            string currentSubstring = previousChar.ToString();

            for (int i = 1; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (currentChar == previousChar)
                {
                    currentSubstring += currentChar;
                }
                else
                {
                    substrings.Add(currentSubstring);
                    currentSubstring = currentChar.ToString();
                }
                previousChar = currentChar;
            }
            substrings.Add(currentSubstring);

            return substrings;
        }

        public List<int> GetSubstringWeights(string s)
        {
            List<string> arrayChar = SplitConsecutiveCharacters(s);
            int length = arrayChar.Count;

            var weights = new List<int>();

            for (int i = 0; i < length; i++)
            {
                string charLoop = arrayChar[i];
                for (int j = 1; j <= charLoop.Length; j++)
                {
                    string substring = charLoop[0..j];
                    int weight = CalculateWeight(substring);
                    weights.Add(weight);
                }
            }
            return weights;
        }

        public int GetCharacterWeight(char c)
        {
            char lowerChar = char.ToLower(c);

            if (lowerChar >= 'a' && lowerChar <= 'z')
            {
                return lowerChar - 'a' + 1;
            }
            else
            {
                throw new ArgumentException("Character is not a valid alphabet letter.");
            }
        }


        public string[] CheckQueries(string s, int[] queries)
        {
            List<int> substringWeights = GetSubstringWeights(s);
            string[] results = new string[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                if (substringWeights.Contains(queries[i]))
                {
                    results[i] = "Yes";
                }
                else
                {
                    results[i] = "No";
                }
            }

            return results;
        }
    }
}
