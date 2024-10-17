class Customer
{
   public static int countCustomer { get; set; } = 0;
   public string customerName { get; set; } = string.Empty;
   public Customer(string input_name)
   {
      customerName = input_name;
      Console.WriteLine($"Customer {customerName} created");
      countCustomer++;
   }
}