using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the logical programs");
            Console.WriteLine("Choose option from below");
            Console.WriteLine("1.Fibbonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n6.StopWatch");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibbonacciSeries.FibNumber();
                    break;
                case 2:
                    perfectNumber.Number();
                    break;
                case 3:
                    PrimeNumber.CheckNum();
                    break;
                case 4:
                    reverseNumber.ReverseProgram(121);
                    break;
                case 6:
                    Watch.CalculateTime();
                    break;
            }
            Console.ReadLine();
        }
    }
}