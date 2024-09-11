namespace Week3;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Lecture 3");

        // Console.WriteLine("Find the largest number of 3");
        // Console.WriteLine("Input 1st number value: ");
        // int? num1 = Convert.ToInt16(Console.ReadLine());

        // Console.WriteLine("Input 2nd number value: ");
        // int num2 = Convert.ToInt16(Console.ReadLine());

        // Console.WriteLine("Input 3rd number value: ");
        // int? num3 = Convert.ToInt16(Console.ReadLine());

        // if (num1 > num2)
        // {
        //     if (num1 > num3)
        //     {
        //         Console.WriteLine($"largest number is: {num1}");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Largest number is: {num3}");
        //     }
        // }
        // else
        // {
        //     if (num2 > num3)
        //     {
        //         Console.WriteLine($"Largest number is: {num2}");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Largest number is: {num3}");
        //     }
        // }

        // Console.WriteLine("Login && Password Logic");
        // string username = "alice", password = "alice123";

        // Console.WriteLine("Please input username: ");
        // string? input_username = Console.ReadLine();

        // Console.WriteLine("Please input password: ");
        // string? input_password = Console.ReadLine();

        // if (username == input_username)
        // {
        //     Console.WriteLine(password == input_password ? "login successfully" : "Login invalid\nPassword is incorrect");
        // }
        // else
        // {
        //     Console.WriteLine("Login invalid\nEmail is incorrect");
        // }

        // Console.WriteLine("Loops");
        // // While comparison

        // int i = 0;
        // string dot = ".";
        // while (i < 33)
        // {
        //     Console.WriteLine($"{i}: {dot}\n");
        //     dot += ".";
        //     i++;
        // }

        // Console.WriteLine("Please input N:");
        // int N = Convert.ToInt16(Console.ReadLine());
        // string symbol = "*";
        // while (N > 0)
        // {
        //     Console.Write($"{symbol}\n");
        //     symbol += "*";
        //     N--;
        // }

        // // Q1 find all odd numbers from [1,10] if while statement
        // int odd_num1 = 1;
        // while (odd_num1 <= 10)
        // {
        //     Console.WriteLine($"{odd_num1}");
        //     odd_num1 += 2;
        // }

        // //Q2: find all odd numbers from [1,10] with if statment
        // int odd_num2 = 1;
        // while (odd_num2 <= 10)
        // {
        //     if (odd_num2 % 2 != 0)
        //     {
        //         Console.Write(odd_num2);
        //     }
        //     odd_num2++;
        // }

        // For Loop
        //start value ; condition ; count

        // Console.WriteLine("starting the for loops");

        // for (int xi = 0; xi < 10; xi++)
        // {
        //     Console.Write(xi);
        // }

        // for (int j = 0; j < 10; j = j + 3)
        // {
        //     Console.Write(j);
        // }
        // for (int k = 10; k < 0; k--)
        // {
        //     Console.Write(k);
        // }
        // Console.WriteLine("\nInput an integer to use for a loop");
        // int N = Convert.ToInt16(Console.ReadLine());

        // for (int numI = 0; numI < N; numI++)
        // {
        //     Console.Write("*");
        // }
        // Console.WriteLine($"\nYou have {N} *'s");

        // Console.WriteLine("Do-While Loop");
        // int attemps = 3;
        // string? input_username2;
        // string username2 = "alice";

        // do
        // {
        //     Console.WriteLine("Please input username:");
        //     input_username2 = Console.ReadLine();
        //     if (input_username2 == username2)
        //     {
        //         Console.WriteLine("Login Successfully");
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Wrong Username");
        //     }
        //     attemps--;
        //     Console.WriteLine($"You have {attemps} attemps left");
        // }
        // while (attemps > 0);


        Console.WriteLine("Nested For Loops");
        for (int row = 0; row < 6; row++)
        {
            Console.Write($"Row:{row} - ");
            for (int col = 0; col < 5; col++)
            {
                Console.Write(col + ' ');
            }
            Console.WriteLine("");
        }
        Console.WriteLine("Nested For Loops");
        for (int row = 0; row < 6; row++)
        {
            Console.Write($"Row:{row} - ");
            for (int col = 0; col < 5; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine("");
        }

        // Conditional Operator (Tinary)
        int numA, numB, max_num;
        Console.WriteLine()
    }
}
