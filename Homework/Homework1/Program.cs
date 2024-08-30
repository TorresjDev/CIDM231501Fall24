namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        /**
        
        Q1 (5 Points) The linear line Equation is: Z = 4X2+3Y, when  X = 2.5, Y=3.3, write a program to:
        calculate the value of Z and print it out in the following format.
        (Hint: in computer programming,  4X2  can be represented as 4*X*X; and use formatted string to print results)

        */

        double x = 2.5;
        double y = 3.3;
        double z = 4 * x * x + 3 * y;

        Console.WriteLine($"X = {x}, Y = {y}");
        Console.WriteLine($"The value of Z is: {z}");

    }
}
