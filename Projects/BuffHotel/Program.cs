namespace BuffHotel;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----CIDM2315 FINAL PROJECT: JESUS TORRES-----");
        Console.WriteLine("        ---WELCOME TO BUFF HOTEL---");
        Console.WriteLine("Please login to continue to the Buff Hotel System");

        bool loggedIn = Login();

        while (!loggedIn)
        {
            Console.WriteLine("Try again? (Y/N)");
            string? tryAgain = Console.ReadLine();
            if (tryAgain?.ToLower() == "n")
            {
                Console.WriteLine("Thank you for stopping by, \n Goodbye!");
                break;
            }
            else if (tryAgain?.ToLower() == "y")
            {
                loggedIn = Login();
            }
        }

        if (loggedIn)
        {
            DatabaseConnect db_conn = new DatabaseConnect();
            bool connected = db_conn.OpenConnection();

        }
    }

    static bool Login()
    {
        Console.WriteLine("Enter Username: ");
        string? username = Console.ReadLine();
        Console.WriteLine("Enter Password: ");
        string? password = Console.ReadLine();

        if (username == "alice" && password == "alice123")
        {
            Console.WriteLine("Login Successful!");
            return true;
        }
        else
        {
            if (username != "alice")
            {
                Console.WriteLine("Invalid Username");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
            return false;
        }
    }



}
