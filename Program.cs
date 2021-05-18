using System;
using System.Collections.Generic;
using rockpaperscissors_csday1.models;

namespace rockpaperscissors_csday1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Rock Paper Scissors? (Y/N)");
      char choice = Console.ReadKey().KeyChar;
      System.Console.WriteLine("");
      if (choice == 'y')
      {
        System.Console.WriteLine("Let's Gooooooooooo! :D ");
      }
      else if (choice == 'n')
      {
        System.Console.WriteLine("Fine Then, Rudey -_-");
      }
      else
      {
        System.Console.WriteLine("How Dare You?");
      }


      //   Start the Game
      Game game = new Game();
      bool playing = true;
      while (playing)
      {
        List<string> computerChoice = new List<string>(){
        "Rock", "Paper", "Scissors"
    };
        Random r = new Random();
        int index = r.Next(0, 3);
        string randomString = computerChoice[index];
        Console.Write("What'll It Be? (R)ock...(P)aper... or (S)cissors?: ");
        string guess = Console.ReadLine();
        //if choices....
        if (guess == 'r')
        {
          System.Console.WriteLine("You chose rock!");
        }
        else if (guess == 'p')
        {
          System.Console.WriteLine("You chose paper!");
        }
        else if (guess == 's')
        {
          System.Console.WriteLine("You chose scissors!");
        }
      }

      //set user choice as a read line since they'll input it.

    }
  }
}
