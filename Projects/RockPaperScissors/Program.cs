Console.WriteLine("  ***STARTING GAME***\n***ROCK PAPER SCISSORS***");
HumanPlayer player_human = new HumanPlayer(5);
ComputerPlayer player_computer = new ComputerPlayer();

while (player_human.GetPoints() > 0)
{
    Console.WriteLine($"You have {player_human.GetPoints()} points.");
    string human_move = player_human.HumanDecision();
    string computer_move = player_computer.ComputerDecision();

    if ((human_move == "rock" && computer_move == "scissors") || (human_move == "scissors" && computer_move == "paper") || (human_move == "paper" && computer_move == "rock"))
    {
        player_human.WinRound();
        Console.WriteLine($"Your Decision: {human_move}\nComputer Decision: {computer_move}\nYou Win!");
    }
    else if ((computer_move == "rock" && human_move == "scissors") || (computer_move == "scissors" && human_move == "paper") || (computer_move == "paper" && human_move == "rock"))
    {
        player_human.LoseRound();
        Console.WriteLine($"Your Decision: {human_move}\nComputer Decision: {computer_move}\nYou Lose!");
    }
    else
    {
        Console.WriteLine($"Your Decision: {human_move}\nComputer Decision: {computer_move}\nIt's a tie!");
    }

    if (player_human.GetPoints() > 0)
    {
        Console.WriteLine("Play again? Input y to continue, or n to exit.");
        string playAgain = Console.ReadLine() ?? string.Empty;
        if (playAgain.ToLower() == "n")
        {
            Console.WriteLine($"Game Over!\nThanks for playing!\nYour High Score: {player_human.GetPoints()}");
            break;
        }
        else if (playAgain.ToLower() == "y")
        {
            Console.WriteLine("Starting next round...");
            continue;
        }
        else
        {
            Console.WriteLine($"Invalid input...\nEnding Game.\nYour total points: {player_human.GetPoints()}");
            break;
        }
    }
    else
    {
        Console.WriteLine("Game Over!\nSorry you lost all your points...\nThanks for playing!");
    }
}

