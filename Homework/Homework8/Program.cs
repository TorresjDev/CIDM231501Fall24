namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Homework 8");
        // Q0: Customers created
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3)

        Console.WriteLine($"Customer 1 age: {cus1.customerAge}");

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 }

    }
}

// Q0: Create a class called Customer
class Customer
{
    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }





}