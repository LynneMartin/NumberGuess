using System;

namespace numberguess
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Random rng = new Random();
      int magicNumber = rng.Next(1, 101);
      System.Console.WriteLine("Guess a random number between 1 and 100:");
      bool guessing = true;
      while (guessing)
      {
        string choice = Console.ReadLine();
        if (Int32.TryParse(choice, out int guessed))
        {

          if (guessed == magicNumber)
          {
            Console.WriteLine("YOU WIN!");
            // guessing = false;
            Console.WriteLine("Press 'A' to play again or any other key to quit");
            ConsoleKeyInfo again = Console.ReadKey();
            if (again.KeyChar == 'A')
            {
              magicNumber = rng.Next(1, 101);
              Console.Clear();
              System.Console.WriteLine("Guess a random number between 1 and 100:");
            }
            else
            {
              guessing = false;
            }
          }
          else if (guessed < magicNumber)
          {
            System.Console.WriteLine("Your guess is too low. Sorry! Guess again.");
          }
          else
          {
            Console.WriteLine("Yikes! Your guess is too high! Guess again.");
          }
        }
      }
    }
  }
}
