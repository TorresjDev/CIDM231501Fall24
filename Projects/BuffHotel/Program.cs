namespace BuffHotel;
using System.Data;
using MySql.Data.MySqlClient;
using DotNetEnv;

class Program
{
    static void Main(string[] args)
    {
        Env.Load("../../.env");
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
            Console.WriteLine("Connecting to the Buff Hotel System...");
            try
            {
                string connectDB = ($"server={Env.GetString("DB_SERVER")};user={Env.GetString("DB_USERNAME")};database={Env.GetString("DATABASE")};port={Env.GetString("DB_PORT")};password={Env.GetString("DB_PASSWORD")}");
                MySqlConnection connection = new MySqlConnection(connectDB);
                connection.Open();
                Console.WriteLine("Connection Successful!");

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Conection failed...\nsorry, please try again later\n\n\nError: {0}", ex.ToString());

            }

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
