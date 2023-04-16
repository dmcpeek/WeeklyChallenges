using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            var booleanValue = ChallengesSet01.AreTwoNumbersTheSame(13, 13);
            Console.WriteLine($"Are the two numbers the same? {booleanValue}");
            Console.WriteLine();

            double subtractValue;
            subtractValue = ChallengesSet01.Subtract(12.9, 3.5);
            Console.WriteLine($"The first number minus the second number equals {subtractValue}");
            Console.WriteLine();

            var addValue = ChallengesSet01.Add(99, 97);
            Console.WriteLine($"The sum of the two numbers is {addValue}");
            Console.WriteLine();

            var smallestValue = ChallengesSet01.GetSmallestNumber(3, 5);
            Console.WriteLine($"The smallest of the two numbers is {smallestValue}");
            Console.WriteLine();

            var multiplyValue = ChallengesSet01.Multiply(112358133144, 31415926);
            Console.WriteLine("The product of the two numbers is " + multiplyValue.ToString("N0"));
            Console.WriteLine();

            var greetingValue = ChallengesSet01.GetGreeting("Bubba Jim Bob Jones");
            Console.WriteLine(greetingValue);
            Console.WriteLine();

            var howdyValue = ChallengesSet01.GetHey();
            Console.WriteLine(howdyValue);
            Console.WriteLine();
        }
    }
}
