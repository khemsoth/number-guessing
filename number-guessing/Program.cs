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
            Console.WriteLine("Welcome to the number guessing game! Please guess a number!");
            int attempts = 10;            
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            do
            {
                Console.WriteLine("I am ready for you to guess! Press enter after your guess.");
                int guess = Int32.Parse(Console.ReadLine());
                if (guess == null)
                {
                    Console.WriteLine("You need to enter a number.");
                }
                else if (guess < number)
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
                    return;
                }
            }
            while (attempts > 0);
            if(attempts == 0)
            {
                Console.WriteLine("Sorry, you are out of attempts!");
            }
            

        }
    }
}
