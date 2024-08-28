// namespace indicates the name of our project/app. Folder to organize code at the highest logical level
namespace HelloWorld;

// A class is a sublevel of namespace -- contains 1 or more classes
class Program //class program is a container

{
    static void Main(string[] args)
    {
        /*this is a comment line*/
        string name = "Jesus Torres";
        // prints hello world
        Console.WriteLine("Hello,\n \"World!\"");
        // prints welcome name
        Console.WriteLine($"Welcome\t-\t {name}\\");

        /*
        \t - tab
        \n - new line
        \"text\"
        \\ - backslash
        */

        // Part 2

        // int = data type / Age = Variable Name / 25 = value
        int Age = 25;
        /* Variable name 
        -good var names
            -must start with letter or underscore (no numbers as start)
            -any set of letters and numbers
            2 ways to create variables
                int = age =20; - declare and initialize
                int Age; - declare at first
                Age = 10; - then initialize

                var _age = 10; - declare and initialize a var
                    -C# automatically assigns value when using var type

        *** best practice to always try to declate variable data type when possible
        
        */


    }
}
