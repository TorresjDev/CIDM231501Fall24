class CreditCard
{
   private int cardNumber;
   public int GetCardNumber()
   {
      return cardNumber;
   }
   public void SetCardNumber(int newNumber)
   {
      cardNumber = newNumber;
   }

   public int cardPin { set; get; }
}