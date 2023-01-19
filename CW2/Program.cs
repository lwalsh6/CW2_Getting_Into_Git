//Logan Walsh
//1-19-2023
//This is a random number game made in C#

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
            //The User's input
            int userGuess;
            //The computer's answer to the game
            int cpuGuess;

            //Used for randomly generating numbers
            Random rnd = new Random();

            //Arbitrary hello world 
            Console.WriteLine("Hello World!!!");
            Console.WriteLine("Welcome to Super Totally Fun Random Number Guessing Game!");

            //User can input a minimum and maximum value
            Console.Write("Enter Min: ");
            //User inputs must be converted from a string to an int to work
            int rndMin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Max: ");
            int rndMax = Convert.ToInt32(Console.ReadLine());

            //Sets the game's answer based on the user's minimum and maximum
            cpuGuess = rnd.Next(rndMin, rndMax);

            //Prompts the user to insert a guess
            Console.Write("Enter Your Guess: ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            //Used to count the number of attempts
            int tries = 1;

            //While the answer is incorrect
            while (userGuess != cpuGuess)
            {
                //Lets the user know of their failure
                Console.WriteLine("You Failed, MISERABLY!");
                //Prompts the user to tell them if their answer was too high or too low
                if (userGuess > cpuGuess)
                {
                    Console.WriteLine("Too High");
                }
                else if (userGuess < cpuGuess)
                {
                    Console.WriteLine("Too Low");
                }
                //Increases tries by one every fail
                tries++;
                Console.Write("Guess Again: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            }

            //Lets the user know they won
            Console.WriteLine(userGuess + " = " + cpuGuess + " So you Won! Conglagurations! A Winner is You!");
            //total number of answers the user inputted
            Console.WriteLine("Number of tries: " + tries);
            Console.ReadKey();
        }

    }
}
