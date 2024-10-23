namespace RockPaperScissors;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****START GAME******\n*****ROCK PAPER SCISSORS******");
        HumanPlayer Human = new HumanPlayer(5);
        // ComputerPlayer Computer = new ComputerPlayer();
        Console.WriteLine($"You have {Human.GetPoints()} points.");

    }
}

