// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace FizzBuzzChallenge
{
    public class Program
    {
        public static string FizzBuzz(int number)
        {
        if (number % 3 == 0  && number % 5 ==0) // checks if divisible by 3 and 5 returns FizzBuzz if meets both
        {
            return "FizzBuzz";
        }
        else if (number % 3 == 0) // checks if divisible by 3
        {
            return "Fizz";
        }
        else if (number % 5 == 0) // checks if divisble by 5
        {
            return "Buzz";
        }
        else
        {
            return number.ToString(); // returns as string
        }
        }
        public static void Main()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine(); // reads user input
            if (int.TryParse(input, out int number)) // takes input to validate it
            {
                Console.WriteLine(FizzBuzz(number)); // call method
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid number:");
            }
        }
    }
}
