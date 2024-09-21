namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Homework 4");

        // Call Q1 Method
        Console.WriteLine("Q1: Enter 2 numbers, to generate largest number");
        Console.WriteLine("Enter 1st number: ");
        int numA = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter 2nd number: ");
        int numB = Convert.ToInt16(Console.ReadLine());
        largestNumber(numA, numB);

        // Call Q2 Method
        Console.WriteLine("Q2: Pattern method");
        Console.WriteLine("Enter a number: ");
        int numQ2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter text left or right: ");
        string? shape = Console.ReadLine();
        PrintShaper(numQ2, shape?.ToLower());
        Console.WriteLine();

    }

    // Q1 Method
    static void largestNumber(int num1, int num2)
    {
        int lgNum = num1 > num2 ? num1 : num2;
        Console.WriteLine($"The largest number is: {lgNum} \n\n");
    }

    // Q2 Method
    static void PrintShaper(int num, string? shape)
    {

        for (int i = 1; i <= num; i++)
        {
            if (shape == "right")
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            else if (shape == "left")
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid shape input, Please enter 'left' or 'right'.");
                break;
            }
            // ! Question
            // ? Why does string? and shape? require a null check but not the int and num when running the code?
        }
    }
}


