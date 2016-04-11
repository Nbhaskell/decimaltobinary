using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimaltobinary
{
    class Program
    {

        // Write a program that converts a decimal to binary.
        // number in decimal form is obtained and is it repeatedly divided by 2 and its binary form is obtained.

        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number to converted to binary: ");

            number = int.Parse(Console.ReadLine());

            int quot;
            string rem = " ";
            while (number>=1)
            {
                quot = number / 2;
                rem += (number % 2).ToString();
                number = quot;
            }
            string bin = " ";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            Console.WriteLine("The binary form of the number given is {0}", bin);
            Console.Read();
        }
    }
}
