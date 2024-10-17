namespace Week8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Week 8!");
        // ? for Student.cs
        // // Student Alice = new Student(111, "Alice", 20);// Student() is invoking the constructor
        // Student Alice = new Student(input_id: 111, input_name: "Alice", input_age: 20);
        // Alice.PrintInfo();
        // Student Bob = new Student();

        // ? for Customer.cs
        // Customer c1 = new Customer("Alice");
        // Console.WriteLine($"Customer count: {Customer.countCustomer}");
        // Customer c2 = new Customer(input_name: "Bob");
        // Console.WriteLine($"Customer count: {Customer.countCustomer}");

        // ? for Computer.cs
        Computer dell = new Computer(1000, "Dell");
        Console.WriteLine($"Computer: {dell.brand} Price: {dell.price}");
        Computer hp = new Computer(price: 1200, brand: "HP");
        Console.WriteLine($"Computer: {hp.brand} Price: {hp.price}");
        dell.ComparePrice(hp);
        hp.ComparePrice(dell);


    }
}

// * Object Orientation
// - organizes software design around objects(data)
// - store & manipulate objects as reusable components
// - objects are instances of classes

// Week7/Student.cs 
// has a good example of a class object that can be reused

// ? Why choose Object Orientation?
// - Organizes real-world entities in the system
// - Encapsulates data and behavior
// - Helps enforce good design principles and practices 
// - Promotes code reusability
// - Reduces maintenance costs making systems more scalable


// * Static keyword
//  - used to indicate that an element (variable, method, property) in a class belongs to the class itself, rather than to instances of the class

//  - see Customer.cs for example of static variable countCustomer