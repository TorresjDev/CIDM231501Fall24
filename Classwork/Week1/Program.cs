namespace Week1;

class Program
{
    static void Main(string[] args)
    {
        // int a = 10;
        // int b = a;
        // b = b + 20; //reassign value of b ()
        // Console.WriteLine(b);


        // formatting strings
        int my_age = 29;
        string my_name = "Alice";
        Console.WriteLine("My name is {0}, I am {1} years old.", my_name, my_age); //string formating
        Console.WriteLine($"My name is {my_name}, I am {my_age} years old"); //string interperlation

        // built-in data types in c#endregion

        int Year = 2022;
        string Major = "CIS";
        float stu_gpa = 3.5f;
        double Weight = 73.5;
        char letter_grade = 'A';
        bool is_online = true;

        Console.WriteLine($"Major: {Major}/n Grade: {letter_grade}");
        Console.WriteLine($"Year: {Year}/n GPA: {stu_gpa}");
        Console.WriteLine($"Weight: {Weight}/n Online: {is_online}");


        const int LabCapacity = 50; // Can NOT reassign value after inital first assign
        // LabCapacity = 30 -- //!running this code will error
        Console.WriteLine(LabCapacity);

        // Arithmetic Operators
        int a = 10;
        int b = 3;
        double c = 2.4;

        Console.WriteLine("Arithmetic Operators");
        Console.WriteLine(a / b); //3
        Console.WriteLine(a / c); //4.166666666666667
        Console.WriteLine(a % b); //1
        Console.WriteLine(a % c);
        Console.WriteLine((c).GetType().Name); // used to check the data type of (var)

        // math precedence order
        // ? 4 + 3 * 5 - mutiplication has priorty
        // use parentheses to change operator precedence
        //? (4 + 3) * 5 - gives addition priorty 

        // increments and decrements 
        int num_a = 1;
        int num_b = ++a;
        // ? Prefix increments (decrements) changes the value then assigns new value
        // ++a;
        // --b;
        Console.WriteLine($"Prefix increments for a: {++a}");
        Console.WriteLine($"Prefix increments for a: {a}");
        // ? Postfix increments (decrements) -  use the value first and then change the value
        // a++'
        // b--
        Console.WriteLine($"Postfix increments for a: {a++}");
        Console.WriteLine($"Postfix increments for a: {a}");


    }
}
