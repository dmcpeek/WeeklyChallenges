using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if ( words == null )
            {
                return false;
            }

            foreach ( string word2 in words )
            {
                if (word2 == null)
                {
                    continue;
                }
                if (ignoreCase == true)
                {
                    string toLower = word2.ToLower();
                    if (toLower == word)
                    {
                        return true;
                    }
                }
                else if ( ignoreCase == false && word2 == word )
                {
                    return true;
                }
            }
            return false;
            //throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            {
                if (num < 2)
                    return false;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                        return false;
                }

                return true;
            }
            //throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for(int i = 0; i <str.Length; i++)
            {
                uindex = true;
                for (int j = 0; j <str.Length; j++) 
                {
                    if (str[i] == str[j] && i != j) 
                    {
                        uindex = false;
                    }
                }
                if (uindex == true) 
                {
                    index = i;
                }
            }
            return index;
            //throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            
            return count;
            //throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }
            
            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }

            return nthElement.ToArray();
            //throw new NotImplementedException();
        }
    }
}
