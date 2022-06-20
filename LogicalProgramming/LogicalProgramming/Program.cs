using System;

namespace LogicalProgramming
{
    internal class Program

    {
        public static void Main()
        {

            int n = 10, firstTerm = 0, secondTerm = 1; 
            Console.WriteLine("Fibonacci Series till " + n + " terms:");

            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine(firstTerm + ", ");


                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
                



            }
        }
    }
}
