namespace RockPaperScissors;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  ***STARTING GAME***\n***ROCK PAPER SCISSORS***");
        HumanPlayer human = new HumanPlayer(5);
        ComputerPlayer computer = new ComputerPlayer();

        while (human.GetPoints() > 0)
        {
            Console.WriteLine($"You have {human.GetPoints()} points.");
            string humanMove = human.HumanDecision();
            string computerMove = computer.ComputerDecision();

            if (humanMove == "rock" && computerMove == "scissors" || humanMove == "scissors" && computerMove == "paper" || humanMove == "paper" && computerMove == "rock")
            {
                Console.WriteLine($"Your Decision: {humanMove}\nComputer Decision: {computerMove}\nYou Win!");
                human.WinRound();
            }
            else if (computerMove == "rock" && humanMove == "scissors" || computerMove == "scissors" && humanMove == "paper" || computerMove == "paper" && humanMove == "rock")
            {
                Console.WriteLine($"Your Decision: {humanMove}\nComputer Decision: {computerMove}\nYou Lose!");
                human.LoseRound();
            }
            else
            {
                Console.WriteLine($"Your Decision: {humanMove}\nComputer Decision: {computerMove}\nIt's a tie!");
            }

            Console.WriteLine("Play again? Input y to continue, or n to exit.");
            string playAgain = Console.ReadLine() ?? string.Empty;
            if (playAgain.ToLower() == "n")
            {
                Console.WriteLine($"Game Over!");
                break;
            }
            else if (playAgain.ToLower() == "y")
            {
                Console.WriteLine("Starting next round...");
                continue;
            }
            else
            {
                Console.WriteLine($"Invalid input...\nEnding Game.\nYour total points: {human.GetPoints()}");
                break;
            }
        }

        Console.WriteLine($"Thanks for playing!\nHigh Score: {human.GetPoints()}");
    }
}

