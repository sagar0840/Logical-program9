using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // 4. write a program that takes a number as input from user. The key number is 4 and the user
    //enters single digit numbers. Ask the user for a number till he gets the
    //correct answer. Then display the number of tries it took to guess the correct number

    internal class Program
    {
        static void Main(string[] args)
        {
            int keynumber = 4, guess, count = 0;
            Console.WriteLine("guess the number (between 0 and 9);");
            do
            {
                Console.WriteLine("enter your guess:");
                guess=int.Parse(Console.ReadLine());
                count++;
            }
            while(guess!=keynumber);
            Console.WriteLine("you guess the correct number after{0} tries",count);

        }
    }
}
