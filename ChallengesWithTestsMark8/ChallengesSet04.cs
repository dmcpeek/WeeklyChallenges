using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int length = numbers.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] = numbers[i] * -1;
                }
                sum += numbers[i];
            }
            return sum;

            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = { str1, str2, str3, str4 };
            int length = strings[0].Length;

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 0)
                {
                    return 0;
                }
                else if (strings[i].Length <= length)
                {
                    length = strings[i].Length;
                }
            }
            return length;

            //throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            int smallest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            return smallest;

            //throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            //throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool triangle = false;

            triangle = ((sideLength1 + sideLength2) > sideLength3) ? true : false;
            if (triangle)
            {
                triangle = ((sideLength1 + sideLength3) > sideLength2) ? true : false;
                if (triangle)
                {
                    triangle = ((sideLength2 + sideLength3) > sideLength1) ? true : false;
                }
            }
            return triangle;

            /* Algorithm from https://www.wikihow.com/Determine-if-Three-Side-Lengths-Are-a-Triangle */
            //throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            return float.TryParse(input, out var number);
            //throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int countNull = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    countNull++;
                }
            }
            return (countNull > objs.Length / 2) ? true : false;
            //throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            double sum = 0;
            double count = 0;
            double length = numbers.Length;


            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            return (sum == 0) ? sum : sum / count;

            //throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;
            if (number < 0)
                throw new ArgumentOutOfRangeException(nameof(number));

            int fact = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
