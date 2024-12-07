using Utilities; // Add this line to include the Room class
using BuffHotel.Controllers;

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

            switch (tryAgain)
            {
                case "n":
                    Console.WriteLine("Thank you for stopping by, \n Goodbye!");
                    return;
                case "y":
                    loggedIn = MethodHelper.Login(username, password);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        Console.WriteLine("Connecting to the database...");
        HotelController controller = new HotelController(db_conn);
        if (!db_conn.EnsureConnection())
        {
            Console.WriteLine("Error: Unable to connect to the database");
            Console.WriteLine("Goodbye!");
            return;
        }
        controller.MainMenu();
    }
}
