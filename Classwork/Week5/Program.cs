namespace Week5;

//* SoloLearn C# Intermediate Classes & Objects
// class Program
// {
//     //* SoloLearn C# Intermediate
//     //? Classes and Objects
//     class Person
//     {
//         int age = 21;
//         string name = "Billy";

//         public void Greet()
//         {
//             Console.WriteLine($"Hello, my name is {name},");
//             Console.WriteLine($" and I am {age} years old.");
//         }
//     }

//     // ? Encapsulation
//     //  - Encapsulation is the concept of restricting access to certain parts of an object to better protect the data it contains.
//     class BankAccount
//     {
//         private double balance = 0; //private will only be accessed within the class
//         public void Deposit(double n)
//         {
//             balance += n;
//         }

//         public void Withdraw(double n)
//         {
//             balance -= n;
//         }

//         public double GetBalance()
//         {
//             return balance;
//         }
//     }

//     // ? Constructors
//     // - A constructor is a special method that is called when an object is created.
//     class Person
//     {
//         private int age;
//         private string name;
//         public Person(string n, int a)
//         {
//             age = a;
//             name = n;
//         }
//         public void Greet()
//         {
//             Console.WriteLine($"Hello, my name is {name}, and I am {age} years old.");
//         }

//     }

//     // ? Properties
//     class Person
//     {
//         private int age;
//         public string Name
//         {
//             get
//             {
//                 return name;
//             }
//             set
//             {
//                 name = value;
//             }
//         }
//         // ? auto complete - a shortcut to create a property
//         // public string Name { get; set; }
//     }
//     static void Main(string[] args)
//     {
//         //* SoloLearn C# Intermediate

//         // ? Classes and Objects
//         Person student1 = new Person();
//         student1.Greet();

//         // ? Encapsulation
//         BankAccount chase = new BankAccount();
//         chase.Deposit(160000);
//         chase.Withdraw(1000);
//         Console.WriteLine("Balance: $" + chase.GetBalance());

//         // ? Constructors
//         Person student1 = new Person("Billy", 21);
//         student1.Greet();

//         // ? Properties
//         Person student1 = new Person();
//         student1.Name = "Billy";
//         Console.WriteLine(student1.Name);


//     }
// }

// * Class Week Lecture
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Week 5 nice!");
        // Console.WriteLine("Please input 2 integers");
        // int int1 = getInteger();
        // int int2 = getInteger();
        // int sum = TwoSum(int1, int2);
        // Console.WriteLine($"{int1} + {int2} = {sum}");

        // Console.WriteLine("Please input your first name");
        // string? fname = Console.ReadLine();
        // Console.WriteLine("Please input your last name");
        // string? lname = Console.ReadLine();
        // // PrintNames(fname, lname); 
        // PrintNames(firstname: fname, lastname: lname);

        // int two_grade_sum = GradeSum(english: 60, math: 90);
        // Console.WriteLine("Sum Grade of two classes:" + two_grade_sum);

        // int three_grade_sum = GradeSum(english: 60, math: 90, java: 100);
        // Console.WriteLine($"Sum Grade of three classes: {three_grade_sum}");

        //! Reference




    }

    // static int getInteger()
    // {
    //     return Convert.ToInt16(Console.ReadLine());
    // }

    // static int TwoSum(int a, int b)
    // {
    //     int sum = a + b;
    //     return sum;
    // }

    // static void PrintNames(string? firstname, string? lastname)
    // {
    //     Console.WriteLine($"Hello! {firstname} {lastname} Welcome! to West Texas A&M University!");
    // }

    // static int GradeSum(int english, int math, int java = 0)
    // { // java value of 0 is set by default but can be overwritten if passed an argument value for java
    //     return english + math + java;
    // }

    // static void refDeposit(ref int accountBalance, int amount)
    // {
    //     accountBalance = accountBalance + amount;
    // }

    // static void refWithDraw(ref int withdrawAmount, int amount)
    // {
    //     withdrawAmount = withdrawAmount - amount;
    // }
}

