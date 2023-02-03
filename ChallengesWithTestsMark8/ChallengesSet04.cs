using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var answer = 0;
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    answer = item + answer;
                }
                if (item % 2 != 0)
                {
                    answer = answer - item;
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() {number1, number2, number3, number4};
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                    sideLength1 + sideLength2 > sideLength3 &&
                    sideLength1 + sideLength3 > sideLength2 &&
                    sideLength3 + sideLength2 > sideLength1
                    );
        }

        public bool IsStringANumber(string input)
        {
            if (input == "")
                return false;
            if (input == null)
            {
                return false;
            }
            string specialChar = @"[az]\|!#$%&/()=?»«@£§€{};'<>_*,[""]";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return false;
            }
            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var nullCount = 0;
            foreach (var item in objs)
            {
                if (item == null)
                {
                    nullCount++;
                }
            }
            if (nullCount >= majority)
            {
                return true;
            }
            else

                return false;
        }

        public double AverageEvens(int[] numbers)
        {

            double sum = 0;
            double numberCount = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum = sum + item;
                    numberCount++;
                }
            }
            double answer = sum / numberCount;
            if (numberCount == 0)
            {
                return sum;
            }
            else

                return answer;
        }

        public int Factorial(int number)
        {
            var result = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0) { return result; }
            while (number != 1)
            {
                result *= number;
                number = number - 1;
            }
            return result;
        }
    }
}
