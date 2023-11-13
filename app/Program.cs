namespace Exercise011
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type a number and press return, twice.");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine(first + " is greater than " + second + ".");
            }
            else if (second > first)
            {
                Console.WriteLine(first + " is less than " + second + ".");
            }
            else
            {
                Console.WriteLine(first + " is equal to " + second + ".");
            }

            PrintUntilNumber(second);
        }

        public static void PrintUntilNumber(int monestiko)
        {
            int number = 1;
            while (number <= monestiko)
            {
                Console.WriteLine(number);
                number++;
            }
        }
    }
}