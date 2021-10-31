using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int CompScore = 0;
            int UserScore = 0;
            while (true)
            {
                Console.WriteLine("Welcome to the number guessing game! Please guess a number between 1-100! First to 5 wins!");
                int attempts = 10;
                bool correct = false;
                Random rnd = new Random();
                int number = rnd.Next(1, 101);
                Console.WriteLine($"Current score: You: {UserScore} | Me: {CompScore}");
                do
                {
                    int guess = Convert.ToInt32(Console.ReadLine());
                    if (guess < number)
                    {
                        attempts--;
                        Console.WriteLine($"You're guess was too low. You have {attempts} guesses left.");
                    }
                    else if (guess > number)
                    {
                        attempts--;
                        Console.WriteLine($"You're guess was too high. You have {attempts} guesses left.");
                    }
                    else if (guess == number)
                    {
                        Console.WriteLine("You've guessed the number!");
                        correct = true;
                        UserScore++;
                    }
                }
                while (correct == false && attempts > 0);

                if (attempts == 0)
                {
                    Console.WriteLine("Sorry, you are out of attempts!");
                    CompScore++;
                }
                if(UserScore == 5 || CompScore == 5)
                {
                    if (UserScore == 5)
                    {
                        Console.WriteLine("You've won the game!");
                        UserScore = 0;
                        CompScore = 0;
                    }
                    else if (CompScore == 5)
                    {
                        Console.WriteLine("I've won!");
                        UserScore = 0;
                        CompScore = 0;
                    }
                    Console.WriteLine("Would you like to restart the game? (yes/no)");
                    if (Console.ReadLine().ToLower() != "yes")
                    {
                        Console.WriteLine("Okay, Goodbye!");
                        break;
                    }
                }
            }
        }
    }
}
