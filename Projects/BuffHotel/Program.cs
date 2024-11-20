namespace BuffHotel;

class Program
{
    static void Main(string[] args)
    {
        DBConnect db_conn;

        Console.WriteLine("-----CIDM2315 FINAL PROJECT: JESUS TORRES-----");
        Console.WriteLine("        ---WELCOME TO BUFF HOTEL---");
        Console.WriteLine("\nPlease login to continue to the Buff Hotel System");

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
            db_conn = new DBConnect();
            Console.WriteLine("Connecting to the database...");
            bool connected = db_conn.OpenConnection();
            MainMenu(db_conn);
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


    public static void MainMenu(DBConnect conn)
    {
        Console.WriteLine("\n***********************************************");
        Console.WriteLine("---> Please select a # option from the menu <---");
        Console.WriteLine("1. Show Available Rooms");
        Console.WriteLine("2. Check-In");
        Console.WriteLine("3. Show Reserved Rooms");
        Console.WriteLine("4. Check-Out");
        Console.WriteLine("5. Log Out");
        Console.WriteLine("***********************************************");
        string? option = Console.ReadLine();

        switch (option)
        {
            case "1":
                Service.ShowAvailableRooms(conn);
                break;
            case "2":
                Service.CheckIn(conn);
                break;
            case "3":
                Service.ShowReservedRooms(conn);
                break;
            case "4":
                Service.CheckOut();
                break;
            case "5":
                Service.LogOut();
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
        }

    }


}
