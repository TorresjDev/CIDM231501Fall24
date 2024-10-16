class PrivateBankAccount
{
   private int balance; // this is example of encapsulation


   public void SaveMoney(int amount)
   {
      balance = balance + amount;
   }

   public void TakeMoney(int amount)
   {
      balance = balance - amount;
   }

   public int ShowBalance()
   {
      return balance;
   }
}


