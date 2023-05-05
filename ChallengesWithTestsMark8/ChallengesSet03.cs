using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {

        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0) return false;
            foreach (var val in vals)
            {
                if (val == false) return true;
            }
            return false;

            //throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            int isOdd = 0;
            if (numbers == null) return false;
            foreach (var val in numbers)
            {
                sum += val;
            }
            return (sum % 2 != 0) ? true : false;
            //{ return false; }
            //else { return true; }

            // Mike's solution: return numbers?.Any() ?? false ? numbers.Sum() % 2 !=0 : false;
            //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;
            foreach (var ch in password)
            {
                if (char.IsUpper(ch))
                {
                    isUpper = true;
                }
                if (char.IsLower(ch))
                {
                    isLower = true;
                }
                if (char.IsNumber(ch))
                {
                    isNumber = true;
                }
            }

            if (isUpper && isLower && isNumber)
            {
                return true;
            }
            else
            {
                return false;
            }

            //throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter = val[0];
            return firstLetter;
            //throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            int length = val.Length;
            return val[length - 1];
            //throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            return (dividend / divisor);
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            {
                return nums.Last() - nums.First();
            }
            //throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            List<int> temp = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    temp.Add(i);
                }
            }
            return temp.ToArray();
            //throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            //throw new NotImplementedException();
        }
    }
}
