class ComputerPlayer
{
   public string ComputerDecision()
   {
      Random rdm = new Random();
      int rnd_num = rdm.Next(0, 3);
      switch (rnd_num)
      {
         case 0:
            return "rock";
         case 1:
            return "paper";
         case 2:
            return "scissors";
         default:
            return "lava rocks!";
      }
   }
}