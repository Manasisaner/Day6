using System;
using BasicLogicalProgramming;
public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome in the Basic logical program");
        Console.WriteLine("Fibbonacci Series 1\n PerfectNumber 2\n Prime Number 3\n ReverseNumber 4\n");
        bool check = true;
        while (check)
        {
            Console.WriteLine("Please Enter the valid number to Execution the Program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibbonacciSeries series = new FibbonacciSeries();
                    series.Fibbonacci();
                    break;

                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.Perfect();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;
                case 4:
                    ReverseNumber  reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;
                case 0:
                    check = false;
                    break;
                default :
                    Console.WriteLine("Please Enter the valid number to Continue Execution the Your Program");
                    break;


                    

            }
        }
    }
}