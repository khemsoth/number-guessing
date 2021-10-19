using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guessing
{
    class Program
    {
        public void Game()
        {
            int attempts = 10;
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            do
            {
                Console.WriteLine("I am ready for you to guess! Press enter after your guess.");
                int? guess = Convert.ToInt32(Console.ReadLine());
                if(guess == null)
                {
                    Console.WriteLine("You need to enter a number.");
                    return;
                }
                else if(guess < number)
                {
                    attempts--;
                    Console.WriteLine($"You're guess was too low. You have {attempts} guesses left.");
                }
                else if (guess > number)
                {
                    attempts--;
                    Console.WriteLine($"You're guess was too high. You have {attempts} guesses left.");
                    
                    return;
                }
                else if(guess == number)
                {
                    Console.WriteLine("You've guessed the number!");

                    return;
                }
            }
            while (attempts > 0);
        }
        static void Main(string[] args)
        {
            int CompScore = 0;
            int UserScore = 0;
            Console.Write("Welcome to the Number Guessing Program. I'll think of a number, and you have 10 guesses to get it right.\n" +
                "After each guess, I will let you know whether my number is higher or lower.\n" +
                "If you guess right, you get a point, if you don't, I get a point.\n" +
                "First to 5 wins!\n" +
                "Press any key to get started.\n" +
                "If you would like to exit the program, press 'ctrl + C' at any time.");
            Console.ReadLine();

            Program p = new Program();
            if(CompScore != 0 && UserScore != 0)
            {
                Console.WriteLine($"The current score is: Computer: {CompScore} You: {UserScore}.\n" +
                    $"Would you like to play again? Answer 'yes' or 'no'.");
                string ans = Console.ReadLine();
                if(ans == "yes")
                {
                    p.Game();
                }
                else if(ans == "no")
                {
                    Console.WriteLine("Okay, see you again soon!");
                }
                else if(ans != "yes" || ans != "no")
                {
                    Console.WriteLine("Please answer 'yes' or 'no'.");
                    string ans2 = Console.ReadLine();
                    if (ans2 == "yes")
                    {
                        p.Game();
                    }
                    else if (ans2 == "no")
                    {
                        Console.WriteLine("Okay, see you again soon!");
                    }
                }
            }
            p.Game();
        }
    }
}
