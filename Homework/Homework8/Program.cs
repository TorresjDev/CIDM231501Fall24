namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Homework 8");
        // call Q0 Class 
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // call Q1 Method
        TotalCredits(customer_list);

        // call Q2 Method
        AmarilloAverageAge(customer_list);

        // call Q3 Method
        CanyonAge(customer_list);
    }
    // Q1 - Method
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = 0;
        foreach (Customer customer in customer_list)
        {
            totalCredit += customer.customerCredit;
        }
        Console.WriteLine($"The total credits: {totalCredit}.");
    }

    // Q2 - Method
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        double totalAge = 0;
        int count = 0;
        foreach (Customer customer in customer_list)
        {
            if (customer.customerCity == "Amarillo")
            {
                totalAge += customer.customerAge;
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"The average age of customers in Amarillo: {totalAge / count}.");
        }
        else
        {
            Console.WriteLine("There is no customer in Amarillo.");
        }
    }

    // Q3 - Method
    public static void CanyonAge(Customer[] customer_list)
    {
        string canyonNames = string.Empty;
        foreach (Customer customer in customer_list)
        {
            if (customer.customerCity == "Canyon" && customer.customerAge > 30)
            {
                canyonNames += customer.customerName + ", ";
            }
        }
        if (canyonNames != string.Empty)
        {
            canyonNames = canyonNames.TrimEnd(',', ' ');
            Console.WriteLine($"Customers who live in Canyon and over 30 years old: {canyonNames}.");
        }
        else
        {
            Console.WriteLine("There is no customer who lives in Canyon and over 30 years old.");
        }
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
