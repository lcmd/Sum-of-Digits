using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits_CodeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            //using the mod version
            ////string numbers = "a group of positive integers";
            //int sum = 0;
            //int num = 0;
            //int r;
            //Console.WriteLine("Enter a Positive Number");
            //num = int.Parse(Console.ReadLine());

            //while (num !=0)
            //{
            //    r = num % 10;
            //    num = num / 10;
            //    sum = sum + r;
            //}

            //Console.WriteLine("Sum of Digits of the Number : " + sum);

            // using another method

            string line = "12345";
            int total = 0;

            char[] newArray = line.ToCharArray();
            for(int i = 0;  i < newArray.Length; i++)
            {
                string currentNumber = newArray[i].ToString();
                total += int.Parse(currentNumber);
            }
            Console.WriteLine(total); 



        }

    }
}
