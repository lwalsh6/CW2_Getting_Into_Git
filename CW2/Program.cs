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

            Console.WriteLine(cpuGuess);
            Console.WriteLine("Hello World!!!");
            Console.WriteLine("Welcome to Super Totally Fun Random Number Guessing Game! Guess numbers 0-100");
            Console.Write("Enter Your Guess: ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            int tries = 0;
            while (userGuess != cpuGuess)
            {
                Console.WriteLine("You Failed, MISERABLY!");
                tries++;
                Console.Write("Guess Again: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            }

            Console.WriteLine(userGuess + " = " + cpuGuess + " So you Won! Conglagurations! A Winner is You!");
            Console.WriteLine("Number of tries: " + tries);
            Console.ReadKey();
        }

    }
}
