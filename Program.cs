using System.Dynamic;

internal class Program
{

  static int PlayerWins = 0;
  static int ComputerWins = 0;
  private static void Main()
  {
    Console.WriteLine("Rock, Paper, Scissors");
    string? userHand = ChooseHand();
    string? computerHand = GetComputerHand();
    Console.Clear();
    Console.WriteLine($"You chose {userHand}");
    Console.WriteLine($"Computer chose {computerHand}");

    if (userHand == "Rock" && computerHand == "Scissors" || userHand == "Scissors" && computerHand == "Paper" || userHand == "Paper" && computerHand == "Rock")
    {
      Console.WriteLine("You win!");
      PlayerWins++;
    }
    if (userHand == "Paper" && computerHand == "Scissors" || userHand == "Rock" && computerHand == "Paper" || userHand == "Scissors" && computerHand == "Rock")
    {
      Console.WriteLine("Computer wins!");
      ComputerWins++;
    }
    if (userHand == computerHand)
    {
      Console.WriteLine("Tie!");
    }

    Console.WriteLine($"You: {PlayerWins} || CPU: {ComputerWins}");

    Console.WriteLine("Do you want to play again? y/n");
    var playAgain = Console.ReadKey().KeyChar;
    if (playAgain == 'y') Main();
    else
    {
      Console.Clear();
      Console.WriteLine("FINAL SCORE:");
      Console.WriteLine($"You: {PlayerWins} || CPU: {ComputerWins}");
    }
  }

  static string ChooseHand()
  {
    Console.Clear();
    Console.WriteLine("Choose A Hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");

    string? userInput = Console.ReadLine();

    if (userInput == "1" || userInput == "z" || userInput == "r")
    {
      return "Rock";
    }
    if (userInput == "2" || userInput == "x" || userInput == "p")
    {
      return "Paper";
    }
    if (userInput == "3" || userInput == "c" || userInput == "s")
    {
      return "Scissors";
    }
    throw new Exception("Not a valid input, try again.");
  }
  static string? GetComputerHand()
  {
    int randomNumber = new Random().Next(1, 4);
    if (randomNumber == 1)
    {
      return "Rock";
    }
    if (randomNumber == 2)
    {
      return "Paper";
    }
    if (randomNumber == 3)
    {
      return "Scissors";
    }
    return "";
  }
}
