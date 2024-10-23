class HumanPlayer
{
   private int points; // The number of points the player has
   public HumanPlayer(int initial)
   {
      this.points = initial;
   }

   public int GetPoints()
   {
      return this.points;
   }
   public void WinRound()
   {
      this.points += 5;
   }

   public void LoseRound()
   {
      this.points -= 5;
   }

   public string HumanDecision()
   {
      string? humanMove = string.Empty;
      Console.WriteLine("Please input your choice: rock, paper, or scissors:");
      humanMove = Console.ReadLine();
      return humanMove;
   }
}