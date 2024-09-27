using System.ComponentModel;

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

        /*
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
                // Console.WriteLine("Hello this is Week 5 part 2");
                // Console.WriteLine("Please enter 2 numbers to find the average");
                // int num1 = Convert.ToInt16(Console.ReadLine());
                // int num2 = Convert.ToInt16(Console.ReadLine());
                // double num3 = 1.5;
                // double avgNum1 = ThreeNumAve(A: num1, B: num2, C: num3);
                // Console.WriteLine($"The average number is: {avgNum1}");

                // Print(CourseName: "Math", PointGrade: 98.5);
                // Print(StuName: "Alice", StuID: 12345); */

        Console.WriteLine("Welcome to Student Summary");
        // Console.WriteLine("Enter student firstname");
        string first_name = "Alice";
        // Console.WriteLine("Enter student lastname");
        string last_name = "Smith";
        // Console.WrtieLine();
        bool driver_license = false;
        double history = 90;
        double math = 100;
        StudentSummary(first_name, last_name, driver_license, history, math);
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

    // ref is used to allow changes to be saved in the original variable. ex: accountBalancec
    // static void refDeposit(ref int accountBalance, int amount)
    // {
    //     accountBalance = accountBalance + amount;
    // }

    // static void refWithDraw(ref int withdrawAmount, int amount)
    // {
    //     withdrawAmount = withdrawAmount - amount;
    // }
    //  out is used to output parameters to transfer data of method
    // static void GetNumbers(out int num1, out int num2) {
    //     Console.WriteLine("Please input two integers:");
    //     num1 = Conver
    // }

    // static double ThreeNumAve(int A, int B, double C = 3.5)
    // {
    //     double avg = (A + B + C) / 3;
    //     return avg;
    // }

    // static void Print(string CourseName, double PointGrade)
    // {
    //     Console.WriteLine($"The grade of {CourseName} is: {PointGrade}");

    // }
    // static void Print(string StuName, int StuID)
    // {
    //     Console.WriteLine($"The Student ID of {StuName} is {StuID}");
    // }

    static void StuInfo(string FirstName, string LastName, bool DriverLicense)
    {
        Console.WriteLine($"Student's full name: {FirstName} {LastName}");
        Console.WriteLine($"Stdent has driver license: {DriverLicense}");
    }
    static double TotalGrade(double Course1 = 0, double Course2 = 0, double Course3 = 0)
    {
        double sum = Course1 + Course2 + Course3;
        return sum;
    }

    // method StudentSummary is involking multiple methods within.
    static void StudentSummary(string _FirstName, string _LastName, bool _DriverLicense, double _Course1 = 0, double _Course2 = 0, double _Course3 = 0)
    {
        StuInfo(_FirstName, _LastName, _DriverLicense);
        double total_grade = TotalGrade(_Course1, _Course2, _Course3);
        Console.WriteLine($"Student's total grade: {total_grade} points");
    }
}

