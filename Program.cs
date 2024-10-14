using System.Dynamic;

internal class Program
{
  private static void Main()
  {
    Console.WriteLine("Rock, Paper, Scissors");
    string userHand = ChooseHand();
    string computerHand = GetComputerHand();
  }

  static string ChooseHand()
  {
    Console.Clear();
    Console.WriteLine("Choose A Hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");

    string? userInput = Console.ReadLine();
    if (userInput != "1")
    {
      if (userInput != "2")
      {
        if (userInput != "3")
        {
          throw new Exception("Not a valid input, try again.");
        }
      }
    }
    if (userInput == "1")
    {
      Console.WriteLine("Rock");
    }
    if (userInput == "2")
    {
      Console.WriteLine("Paper");
    }
    if (userInput == "3")
    {
      Console.WriteLine("Scissors");
    }
    return "";
  }
  static string? GetComputerHand()
  {
    int randomNumber = new Random().Next(1, 4);
    if (randomNumber == 1)
    {
      Console.WriteLine("Rock");
    }
    if (randomNumber == 2)
    {
      Console.WriteLine("Paper");
    }
    if (randomNumber == 3)
    {
      Console.WriteLine("Scissors");
    }
    return "";
  }
}
