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


// * Encapsulation means:
//  - Combining data and methods that operate on that data into a single class
// - Restricting access to inner components of the class (access control)
