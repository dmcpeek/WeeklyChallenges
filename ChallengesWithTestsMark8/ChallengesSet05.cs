using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }

            int remainder = startNumber % n;
            if (remainder == 0)
            {
                return startNumber + n;
            }

            int difference = n - remainder;
            int nextNumber = startNumber + difference;
            return nextNumber;

            //throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0.0)
                {
                    business.Name = "CLOSED";
                }
            }
            //throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {  
                return false; 
            }

            int number = 0;
            for (int i = 0; i < numbers.Length - 1; i++) 
            {
                number = numbers[i];
                if (number <= numbers[i + 1])
                {
                    number = numbers[i + 1];
                }
                else
                {
                    return false;
                }
            }
            return true;
            //throw new NotImplementedException();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
            //throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    sentence += word.Trim() + " ";
                }
            }

            if (!string.IsNullOrEmpty(sentence))
            {
                sentence = sentence.TrimEnd();
                sentence += ".";
            }

            return sentence;
            //throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {

            if (elements == null)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();

            //throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            for (int i = 0; i < nums.Length - 1; i++)
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
