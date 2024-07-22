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
          Console.WriteLine("Welcome to the game! Please enter first value (Rock, Paper or Scissors):  ");
          string x = Console.ReadLine();
          x = x.ToLower();
          Console.WriteLine("Please enter second value (Rock, Paper or Scissors): ");
          string y = Console.ReadLine();
          y = y.ToLower();
          
          if(x == a && y == a || x == b && y == b || x == c && y == c ){
            Console.WriteLine("It is a tie.");
          }
          else if(x == a && y == c || x == b && y == a || x == c && y == b){
            Console.WriteLine("Win the first player.");
          }
          else if (y == a && x == c || y == b && x == a || y == c && x == b){
            Console.WriteLine("Win the second player.");
          }
          else{
            Console.WriteLine("Invalide one of the values.");
          }
        }
    }
}