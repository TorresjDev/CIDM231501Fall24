namespace Homework2;

class Program
{
    static void Main(string[] args)
    {

        //Code for Q1
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


        //Code for Q2
        Console.WriteLine("Small Number Input Finder");

        Console.WriteLine("Please input the first number: ");
        string? num1 = Console.ReadLine();

        Console.WriteLine("Please input the second number: ");
        string? num2 = Console.ReadLine();

        Console.WriteLine("Please input the third number: ");
        string? num3 = Console.ReadLine();



        //Code for BQ


    }
}
