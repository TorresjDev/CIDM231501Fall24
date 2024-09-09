namespace Week3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lecture 3");

        Console.WriteLine("Find the largest number of 3");
        Console.WriteLine("Input 1st number value: ");
        int? num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input 2nd number value: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input 3rd number value: ");
        int? num3 = Convert.ToInt16(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine($"largest number is: {num1}");
            }
            else
            {
                Console.WriteLine($"Largest number is: {num3}");
            }
        }
        else
        {
            if (num2 > num3)
            {
                Console.WriteLine($"Largest number is: {num2}");
            }
            else
            {
                Console.WriteLine($"Largest number is: {num3}");
            }
        }

        Console.WriteLine("Login && Password Logic");
        string username = "alice", password = "alice123";

        Console.WriteLine("Please input username: ");
        string? input_username = Console.ReadLine();

        Console.WriteLine("Please input password: ");
        string? input_password = Console.ReadLine();

        if (username == input_username)
        {
            Console.WriteLine(password == input_password ? "login successfully" : "Login invalid\nPassword is incorrect");
        }
        else
        {
            Console.WriteLine("Login invalid\nEmail is incorrect");
        }

        Console.WriteLine("Loops");
        // While comparison

        int i = 0;
        string dot = ".";
        while (i < 33)
        {
            Console.WriteLine($"{i}: {dot}\n");
            dot += ".";
            i++;
        }

        Console.WriteLine("Please input N:");
        int N = Convert.ToInt16(Console.ReadLine());
        string symbol = "*";
        while (N > 0)
        {
            Console.Write($"{symbol}\n");
            symbol += "*";
            N--;
        }

        // Q1 find all odd numbers from [1,10] if while statement
        int odd_num1 = 1;
        while (odd_num1 <= 10)
        {
            Console.WriteLine($"{odd_num1}");
            odd_num1 += 2;
        }

        //Q2: find all odd numbers from [1,10] with if statment
        int odd_num2 = 1;
        while (odd_num2 <= 10)
        {
            if (odd_num2 % 2 != 0)
            {
                Console.Write(odd_num2);
            }
            odd_num2++;
        }

    }
}
