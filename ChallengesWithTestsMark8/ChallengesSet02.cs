using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (char.IsLetter(c));

            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);

            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);

            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            // I had to look up a function to use with IEnumerable. I'd like to learn what this type is.
            double min = double.MaxValue;
            double max = double.MinValue;
            
            if (numbers == null || numbers.Any() == false)
            {
                return 0;
            }
            else 
            {

                foreach (var number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                    if (number > max)
                    {
                        max = number;
                    }
                        
                }

            }
            return (min + max);
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var result = str1.Length <= str2.Length ? str1.Length : str2.Length;
            
            return result;

            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            { 
                return 0; 
            }

            int sum = 0;
           foreach (int number in numbers)
           {
                sum += number;
           }
            return sum;
            
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                if(number % 2 == 0)
                {
                    sum += number;
                }

            }
            return sum;
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            { 
                return false; 
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            
            bool odd = (sum == 0 || sum % 2 == 0) ? false : true;
            return odd;

            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (int i = 1; i < number; i+=2)
            {
                count++;
            }
            return count;
            //throw new NotImplementedException();
        }
    }
}
