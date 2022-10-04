using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool guessCorrect = false;
            Random random = new Random();
            int correct = random.Next(1, 1000);
            Console.WriteLine("Guess a number and use the clues to get the right number!");
            while (!guessCorrect)
            {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess < correct)
                {
                    Console.WriteLine("The correct number is bigger");
                }
                else if (guess > correct)
                {
                    Console.WriteLine("The correct number is smaller");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    guessCorrect = true;
                }
            }
            Console.WriteLine("Congratulations!");
        }
    }
}
