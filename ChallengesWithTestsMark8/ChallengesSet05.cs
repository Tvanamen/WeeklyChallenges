using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
//done     
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber = startNumber + 1;
            while (startNumber % n != 0)
            {
                startNumber++;    
            }
            return startNumber;
        }
//done
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }
//done
        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Length == 0)
            {
                return false; 
            }           
            var x = numbers[0];
           foreach(int n in numbers)
            {
               if(x <= n)
                {
                    x = n;
                }else
                    return false;                  
            }
           return true;
        }
//done
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Length == 0)
            {
                return 0;
            }
            var n = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    return n;
                }
                if (numbers[i] % 2 == 0)
                {
                    n = n + numbers[i+1];                   
                }
            }
            return n;          
        } 
        public string TurnWordsIntoSentence(string[] words)
        {
            if ((words == null) || (words.Length == 0))
            {
                return "";
            }
            string sentence = "";
            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            if (sentence.Length == 0)
            {
                return "";
            }
            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;
          
        }
//done
        public double[] GetEveryFourthElement(List<double> elements)
        {
            var fours = new List<double>();
            if (elements == null || elements.Count == 0 || elements.Count < 4)
            {
                return fours.ToArray();
            }
                for (int i = 0; i < elements.Count; i++)
                {
                    i = i + 3;                  
                    if (i >= elements.Count)
                    {
                    i = elements.Count - 1;
                    return fours.ToArray();
                    }
                    fours.Add(elements[i]);
            }
            return fours.ToArray();
        }
//done
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if(nums.Length < 2)
            {
                return false;
            }
            for (int i = 0;i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
