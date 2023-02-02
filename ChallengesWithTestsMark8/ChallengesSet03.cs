using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(var items in vals)
            {
                if (items == false)
                {
                    return true;
                } 
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = 0;
            if (numbers == null) { return false; }

            foreach(int item in numbers)
            {
                if (item % 2 != 0)
                {
                   sum = item + sum; 
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var upper = false;
            var lower = false;
            var digit = false;

            foreach(char item in password)
            {
                if (char.IsUpper(item)) 
                {
                    upper = true;
                } 
                if (char.IsLower(item))
                {
                    lower = true;
                }
                if (char.IsDigit(item))
                {
                    digit = true;
                }
                if (lower == true && upper == true && digit == true)
                {
                    return true;
                }
            }
             return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter = val[0];
            return firstLetter;
      
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLetter = val[val.Length - 1];
            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            var answer = dividend / divisor;
            return answer;
        }

        public int LastMinusFirst(int[] nums)
        {
            int last = nums[nums.Length -1];
            int first = nums[0];
            return last - first;
            
        }

        public int[] GetOddsBelow100()
        {
            var numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
