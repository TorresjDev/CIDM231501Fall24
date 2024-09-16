namespace Week4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Week 3");
        int num = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Please input an integer");
            num = Convert.ToInt16(Console.ReadLine());
            num += num;

        }
        Console.WriteLine($"The total is {num}");

        string username = "alice";
        string password = "alice123";

        Console.WriteLine("Exercise 2");
        int attempt = 0;
        int max_attempt = 3;
        do
        {
            if (attempt > 0)
            {
                Console.WriteLine($"You have {max_attempt - attempt} attemps");
            }
            Console.WriteLine("Enter Username: ");
            string? input_username = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string? input_password = Console.ReadLine();

            if (input_username == username && input_password == password)
            {
                Console.WriteLine("Login Successfull");
                break;
            }
            if (input_username != username)
            {
                Console.WriteLine("username is incorrect");
            }
            if (input_password != password)
            {
                Console.WriteLine("password is incorrect");
            }
            attempt++;
        }
        while (attempt < max_attempt);

        int stu_id1 = 101; string stu_name1 = "Alice";
        int stu_id2 = 102; string stu_name2 = "Bob";
        int stu_id3 = 103; string stu_name3 = "Jim";
        int stu_id4 = 104; string stu_name4 = "Bill";
        Console.WriteLine("Using WelcomeMessage && PrintWords Methods");
        PrintWords(); WelcomeMessage(stu_id1, stu_name1); // invoking UDM() 
        PrintWords(); WelcomeMessage(stu_id3, stu_name3);
        PrintWords(); WelcomeMessage(stu_id2, stu_name2);
        PrintWords(); WelcomeMessage(stu_id4, stu_name4);
    }

    // WelcomeMessage is a user-defined Method 
    static void WelcomeMessage(int stu_id, string stu_name)
    {
        Console.WriteLine($"{stu_name}! Your Student ID: {stu_id}!");
    }

    static void PrintWords()
    {
        Console.Write("Welcome to WT! ");
    }
}
