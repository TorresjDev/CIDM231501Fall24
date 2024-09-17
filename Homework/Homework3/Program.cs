namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //* Code for Q1
        Console.WriteLine("Is N a Prime Number");
        Console.WriteLine("Input an integer: ");
        int N = Convert.ToInt16(Console.ReadLine());
        bool isPrime = true;
        if (N <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"Yes! {N} is a prime number");
        }
        else
        {
            Console.WriteLine($"No, {N} is not a prime number");
        }
        Console.WriteLine("End of Q1");


        //* Code for Q2
        Console.WriteLine("Print # amounts");
        Console.WriteLine("Input an integer: ");
        int num = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        Console.WriteLine("End of Q2");

        //* Code for BQ
        Console.WriteLine("Diagonal Pattern");
        int num1 = Convert.ToInt16(Console.ReadLine());

        for (int i = 1; i <= num1; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("End of BQ");

    }
}
