using Utilities; // Add this line to include the Room class


namespace BuffHotel;

class Program
{
    static void Main(string[] args)
    {
        DBConnect db_conn = new DBConnect();
        string username = db_conn.GetUsername();
        string password = db_conn.GetPassword();

        Console.WriteLine("-----CIDM2315 FINAL PROJECT: JESUS TORRES-----");
        Console.WriteLine("        ---WELCOME TO BUFF HOTEL---");
        Console.WriteLine("\nPlease login to continue to the Buff Hotel System");

        bool loggedIn = MethodHelper.Login(username, password);

        while (!loggedIn)
        {
            Console.WriteLine("Try again? (Y/N)");
            string? tryAgain = Console.ReadLine()?.Trim().ToLower();
            if (tryAgain == "n")
            {
                Console.WriteLine("Thank you for stopping by, \n Goodbye!");
                break;
            }
            else if (tryAgain == "y")
            {
                loggedIn = MethodHelper.Login(username, password);
            }
        }

        if (loggedIn)
        {
            // db_conn = new DBConnect();
            Console.WriteLine("Connecting to the database...");
            bool connected = db_conn.OpenConnection();
            if (!connected)
            {
                Console.WriteLine("Error: Unable to connect to the database");
                Console.WriteLine("Goodbye!");
                return;
            }
            MethodHelper.MainMenu(db_conn);
        }
    }
}
