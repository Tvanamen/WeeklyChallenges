using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if(string.Equals(words,null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> low = words.Select(x => x.ToLower()).ToList();
                containsWord = low.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            int i;
            for (i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }              
            }
            if (i == num)
            {
                return true;
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool unique;
            for (int i = 0; i < str.Length; i++)
            {
                unique = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        unique = false;
                    }
                }
                if(unique == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {          
            int countMax = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    count++;
                    if (count > countMax)
                    {
                        countMax = count;
                    }
                }
            }
            return countMax;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nth = new List<double>();
            double[] nullCheck = new double[0];
            if (elements == null)
            {
                return nullCheck;
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nth.Add(elements[i]);
                }
                if (n < 0 || n > elements.Count)
                {
                    nth.Clear();
                }
            }
            double[] finalArray = nth.ToArray();
            return finalArray;
        }
    }
}
