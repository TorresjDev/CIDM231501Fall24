namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Homework 5");
        // * Q1
        Console.WriteLine("Q1: Enter 2 numbers, to generate largest number");
        int numA1 = Convert.ToInt16(Console.ReadLine());
        int numA2 = Convert.ToInt16(Console.ReadLine());
        int numALg = findLgNum(numA1, numA2);
        Console.WriteLine($"The largest number is: {numALg} \n");

        // * Q2
        Console.WriteLine("Q2: Enter 4 numbers, to generate largest number");
        int numB1 = Convert.ToInt16(Console.ReadLine());
        int numB2 = Convert.ToInt16(Console.ReadLine());
        int numB3 = Convert.ToInt16(Console.ReadLine());
        int numB4 = Convert.ToInt16(Console.ReadLine());
        int numBLg = findLgNum(findLgNum(numB1, numB2), findLgNum(numB3, numB4));
        Console.WriteLine($"The largest number is: {numBLg} \n");

        //  * Q3
        Console.WriteLine("Q3: Create Account");
        createAccount();
    }
    static int findLgNum(int num1, int num2)
    {
        int lgNum = num1 > num2 ? num1 : num2;
        return lgNum;
    }

    static bool checkAge(int birth_year)
    {
        int age = DateTime.Now.Year - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Create an Account");
        Console.WriteLine("Enter your username:");
        string? username = Console.ReadLine();
        Console.WriteLine("Enter your password:");
        string? password = Console.ReadLine();
        Console.WriteLine("Confirm password \n re-enter your password:");
        string? password2 = Console.ReadLine();
        Console.WriteLine("Enter your birth year: ");
        int birthYr = Convert.ToInt16(Console.ReadLine());
        bool isOfAge = checkAge(birthYr);

        if (isOfAge)
        {
            while (password != password2)
            {
                Console.WriteLine("Passwords do not match, please re-enter your passwords");
                password = Console.ReadLine();
                password2 = Console.ReadLine();
            }
            Console.WriteLine("Account created successfully!");
            Console.WriteLine($"Welcome {username}");
        }
        else
        {
            Console.WriteLine("Sorry, must be 18 years or older to create an account...");
        }
    }
}
