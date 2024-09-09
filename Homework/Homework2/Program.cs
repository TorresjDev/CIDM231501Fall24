namespace Homework2;

class Program
{
    static void Main(string[] args)
    {

        //* Code for Q1
        Console.WriteLine("Grade Letter GPA Point Converter");

        Console.WriteLine("Please input a letter grade: ");
        // ? is used to satisfy the nullable reference exception errors
        string? grade = Console.ReadLine()?.ToUpper(); // To upper is used to convert the input to uppercase to account for lower case inputs

        switch (grade)
        {
            case "A":
                Console.WriteLine("GPA Point: 4");
                break;
            case "B":
                Console.WriteLine("GPA Point: 3");
                break;
            case "C":
                Console.WriteLine("GPA Point: 2");
                break;
            case "D":
                Console.WriteLine("GPA Point: 1");
                break;
            case "F":
                Console.WriteLine("GPA Point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade");
                break;
        }

        //* Code for Q2
        Console.WriteLine("Small Number Input Finder");

        Console.WriteLine("Please input the first number: ");
        string? num1 = Console.ReadLine();
        int num1_Int = Convert.ToInt16(num1);

        Console.WriteLine("Please input the second number: ");
        string? num2 = Console.ReadLine();
        int num2_Int = Convert.ToInt16(num2);

        Console.WriteLine("Please input the third number: ");
        int num3_Int = Convert.ToInt16(Console.ReadLine()); // Can be converted directly without requiring a separate variable

        if (num1_Int < num2_Int && num1_Int < num3_Int)
        {
            Console.WriteLine($"The smallest value is: {num1_Int}");
        }
        else if (num2_Int < num1_Int && num2_Int < num3_Int)
        {
            Console.WriteLine($"The smallest value is: {num2_Int}");
        }
        else if (num3_Int < num1_Int && num3_Int < num2_Int)
        {
            Console.WriteLine($"The smallest value is: {num3_Int}");
        }
        else
        {
            Console.WriteLine("There are two or more numbers that are the smallest");
        }

        //* Code for BQ
        Console.WriteLine("Leap Year Checker");

        Console.WriteLine("Please input a year: ");
        int year = Convert.ToInt16(Console.ReadLine());

        // Leap years are any year that can be % by 4, but cannot be % by 100 unless it can be % by 400
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year ");
        }
    }
}
