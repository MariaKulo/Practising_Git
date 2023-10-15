namespace Exercise011
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintUntilNumber(3);
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