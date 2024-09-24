namespace Week5;

class Program
{
    //* SoloLearn C# Intermediate
    //? Classes and Objects
    /*  class Person
      {
          int age = 21;
          string name = "Billy";

          public void Greet()
          {
              Console.WriteLine($"Hello, my name is {name},");
              Console.WriteLine($" and I am {age} years old.");
          }
      } */

    // ? Encapsulation
    //  - Encapsulation is the concept of restricting access to certain parts of an object to better protect the data it contains.
    /* class BankAccount
{
    private double balance = 0; //private will only be accessed within the class
    public void Deposit(double n)
    {
        balance += n;
    }

    public void Withdraw(double n)
    {
        balance -= n;
    }

    public double GetBalance()
    {
        return balance;
    }
} */

    // ? Constructors
    // - A constructor is a special method that is called when an object is created.
    /* class Person
     {
         private int age;
         private string name;
         public Person(string n, int a)
         {
             age = a;
             name = n;
         }
         public void Greet()
         {
             Console.WriteLine($"Hello, my name is {name}, and I am {age} years old.");
         }

     }*/

    // ? Properties
    class Person
    {
        private int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        // ? auto complete - a shortcut to create a property
        // public string Name { get; set; }
    }
    static void Main(string[] args)
    {
        //* SoloLearn C# Intermediate
        /*
        // ? Classes and Objects
        // Person student1 = new Person();
        // student1.Greet();

        // ? Encapsulation
        // BankAccount chase = new BankAccount();
        // chase.Deposit(160000);
        // chase.Withdraw(1000);
        // Console.WriteLine("Balance: $" + chase.GetBalance());

        // ? Constructors
        // Person student1 = new Person("Billy", 21);
        // student1.Greet();

        // ? Properties
        // Person student1 = new Person();
        // student1.Name = "Billy";
        // Console.WriteLine(student1.Name);
        */

    }
}

