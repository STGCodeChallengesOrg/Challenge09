using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Code challenge #9:
You are given an integer, N. Write a program to determine if N is an element of the Fibonacci Sequence.
 
The first few elements of fibonacci sequence are 0,1,1,2,3,5,8,13,⋯ A fibonacci sequence is one where every element is a sum of the previous two elements in the sequence. 
The first two elements are 0 and 1.
 
or in Math terms:
 
Fn = (Fn - 1) + (Fn - 2)
 
your routine will take an array of integers.  You need to go through the array and determine if each integer is a fibonacci number or not.
 
Sample Input
 
5,7,8
 
Sample Output
 
IsFibo,IsNotFibo,IsFibo
 
Explanation 
5 is a Fibonacci number given by fib(5)=3+2 
7 is not a Fibonacci number 
8 is a Fibonacci number given by fib(6)=5+3
 */
namespace CodeChallenge09_FibonacciCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("\n\nEnter an array of numbers (comma or space separated) to check if they're part of the Fibonacci sequence (q to quit): ");
                input = Console.ReadLine();
                var stringArray = input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                var fibonacciBoolArray = parseFibonacci(stringArray);
                for (int i = 0; i < stringArray.Length; i++)
			    {
			        Console.WriteLine("{0} : {1}", stringArray[i], fibonacciBoolArray[i]);
			    }
                
            } while (input != "q");
        }

        /// <summary>
        /// For each value in array, returns boolean indicating whether element is part of Fibonacci sequence
        /// </summary>
        /// <param name="values">values to check (invalid numbers return false)</param>
        /// <returns>boolean array</returns>
        public static bool[] parseFibonacci(string[] values) 
        {
            var boolArray = new bool[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                long num;
                if (!Int64.TryParse(values[i], out num))
                {
                    boolArray[i] = false;
                }
                else
                {
                    boolArray[i] = isFibonacci(num);
                }
            }
            return boolArray;
        }

        private static bool isFibonacci(long num)
        {
            bool isFibonacci = isPerfectSquare(5 * (num * num) - 4) || isPerfectSquare(5 * (num * num) + 4);
            return isFibonacci;
        }

        private static bool isPerfectSquare(double num)
        {
            bool isPerfectSquare = (Math.Sqrt(num)) % 1 == 0;
            return isPerfectSquare;
        }
    }
}
