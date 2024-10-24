class HumanPlayer
{
   private int points; // The number of points the player has
   public HumanPlayer(int initial)
   {
      this.points = initial;
   }

   public int GetPoints()
   {
      return points;
   }
   public void WinRound()
   {
      points += 5;
   }

   public void LoseRound()
   {
      points -= 5;
   }

   public string HumanDecision()
   {
      Console.WriteLine("Please input your choice: rock, paper, or scissors:");
      string humanMove = Console.ReadLine() ?? string.Empty;
      return humanMove.ToLower();
   }
}