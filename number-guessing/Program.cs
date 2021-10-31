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
            while (true)
            {
                Console.WriteLine("Welcome to the number guessing game! Please guess a number between 1-100!");
                int attempts = 10;
                bool correct = false;
                Random rnd = new Random();
                int number = rnd.Next(1, 101);
                Console.WriteLine($"Number: {number}");
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
                    }
                }
                while (correct == false && attempts > 0);

                if (attempts == 0)
                {
                    Console.WriteLine("Sorry, you are out of attempts!");
                }
                Console.WriteLine("Would you like to play again? (yes/no)");
                if(Console.ReadLine().ToLower() != "yes")
                {
                    Console.WriteLine("Okay, Goodbye!");
                    break;
                }
            }


        }
    }
}
