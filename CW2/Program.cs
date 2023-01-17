using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    class Program //Class name, can be changed
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            
            int userGuess;
            int cpuGuess;

            Random rnd = new Random();
            cpuGuess = rnd.Next(0, 100);

            Console.WriteLine("Hello World!!!");
            Console.WriteLine("Welcome to Super Totally Fun Random Number Guessing Game! Guess numbers 0-100");
            Console.Write("Enter Your Guess: ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine("User's Answer:  " + userGuess);
            Console.WriteLine("Correct Answer: " + cpuGuess);
            Console.WriteLine();
            Console.ReadKey();

            if (userGuess == cpuGuess)
            {
                Console.WriteLine("You Won");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You Failed, MISERABLY!");
                Console.ReadKey();
            }
        }
    }
}
