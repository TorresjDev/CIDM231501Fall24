using BuffHotel.Models;

namespace BuffHotel;

class Program
{
    static void Main(string[] args)
    {
        DBConnect db_conn = new DBConnect();
        string username = db_conn.username;
        string password = db_conn.password;

        Console.WriteLine("-----CIDM2315 FINAL PROJECT: JESUS TORRES-----");
        Console.WriteLine("        ---WELCOME TO BUFF HOTEL---");
        Console.WriteLine("\nPlease login to continue to the Buff Hotel System");

        bool loggedIn = Login(username, password);

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
                loggedIn = Login(username, password);
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
            MainMenu(db_conn);
        }
    }

    static bool Login(string uName, string pWord)
    {
        Console.WriteLine("Enter Username: ");
        string? username = Console.ReadLine()?.Trim().ToLower();
        Console.WriteLine("Enter Password: ");
        string? password = Console.ReadLine()?.Trim().ToLower();

        if (username == uName && password == pWord)
        {
            Console.WriteLine("Login Successful!");
            return true;
        }
        else
        {
            if (username != uName)
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

    public static void MainMenu(DBConnect conn)
    {
        string? option = string.Empty;
        List<AvailableRoom> avbRooms = new List<AvailableRoom>();
        List<ReservedRoom> resRooms = new List<ReservedRoom>();

        if (avbRooms.Count == 0)
        {
            avbRooms = Service.GetAvRooms(conn);
        }

        if (resRooms.Count == 0)
        {
            resRooms = Service.GetResRooms(conn);
        }

        do
        {
            Console.WriteLine("\n***********************************************");
            Console.WriteLine("---> Please select a # option from the menu <---");
            Console.WriteLine(" 1. Show Available Rooms");
            Console.WriteLine(" 2. Check-In");
            Console.WriteLine(" 3. Show Reserved Rooms");
            Console.WriteLine(" 4. Check-Out");
            Console.WriteLine(" 5. Log Out");
            Console.WriteLine("***********************************************");
            option = Console.ReadLine()?.Trim();

            switch (option)
            {
                case "1":
                    Service.FilterAvailableRooms(avbRooms);
                    break;
                case "2":
                    Service.CheckIn(conn, avbRooms);
                    break;
                case "3":
                    Service.FilterReservedRooms(resRooms);
                    break;
                case "4":
                    Service.CheckOut(conn, resRooms);
                    break;
                case "5":
                    Service.LogOut();
                    break;
                default:
                    Console.WriteLine("\nInvalid Option");
                    Console.WriteLine(">>> Press any key to return to the main menu...");
                    Console.ReadKey();
                    break;
            }
        } while (option != "5");

    }


}
