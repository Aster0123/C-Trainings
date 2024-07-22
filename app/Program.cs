using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string a = "rock";
          string b = "paper";
          string c = "scissors";
          string[] options = [a, b, c];
          Console.WriteLine("Welcome to the game! Please enter first value (Rock, Paper or Scissors):  ");
          string x = Console.ReadLine()!;
          x = x.ToLower();
          if (!options.Contains(x)) {
            Console.WriteLine("You fucking donkey, ROCK PAPER OR SCISSORS WHAT IS SO HARD ABOUT THAT");
            return;
          }
          Console.WriteLine("Please enter second value (Rock, Paper or Scissors): ");
          string y = Console.ReadLine()!;
          y = y.ToLower();
          if (!options.Contains(y)) {
            Console.WriteLine("You fucking donkey, ROCK PAPER OR SCISSORS WHAT IS SO HARD ABOUT THAT");
            return;
          }
          if(x == y){
            Console.WriteLine("It is a tie.");
          }
          else if(x == a && y == c || x == b && y == a || x == c && y == b){
            Console.WriteLine("Win the first player.");
          }
          else {
            Console.WriteLine("Win the second player.");
          }
        }
    }
}