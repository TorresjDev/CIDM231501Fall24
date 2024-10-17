class Computer
{
   public int price { get; set; } = 0;
   public string brand { get; set; } = string.Empty;

   public Computer(int price, string brand)
   {
      this.price = price;
      this.brand = brand;
   }

   public void ComparePrice(Computer objComputer)
   {
      Console.WriteLine($"Current Object is: {this.brand}");
      if (this.price <= objComputer.price)
      {
         Console.WriteLine($"{this.brand} is cheaper");
      }
      else
      {
         Console.WriteLine($"{objComputer.brand} is cheaper");
      }
   }

}

// * This keyword
// - refers to the current object(instance) of the class
// - used to access members of the current object
