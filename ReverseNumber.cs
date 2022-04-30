using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{


    public class ReverseNumber
    {
        int rem = 0, sum = 0;
        public void Reverse()
        {
            Console.WriteLine("Enter the Number to Calculate the Factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            // int num = 32546;
            int temp = num;

            for (int i = 1; i <= num; i++)
            {
                rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse number is  :" + " " + sum);
            if (sum == temp)
            {
                Console.WriteLine("Reverse Number is Paliddrom :" + " " + sum);
            }
            else
            {
                Console.WriteLine("Reverse Number is not Paliddrom :" + " " + sum);
            }
        }
    }
}