namespace BuffHotel;
using System.Data;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        DatabaseConnect db_conn;

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
            db_conn = new DatabaseConnect();
            bool connected = db_conn.OpenConnection();
            Console.WriteLine();
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

    static void MainMenu(DatabaseConnect conn)
    {
        Console.WriteLine("***********************************************");
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
                ShowAvailableRooms(conn);
                break;
            case "2":
                CheckIn(conn);
                break;
            case "3":
                ShowReservedRooms(conn);
                break;
            case "4":
                CheckOut();
                break;
            case "5":
                LogOut();
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }

    static void ShowAvailableRooms(DatabaseConnect conn)
    {
        if (conn.GetConnection().State == ConnectionState.Open)
        { // Check if the connection is open before executing the query
            try
            {

                MySqlCommand cmd = new MySqlCommand("GetAvailableRooms", conn.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader rdr = cmd.ExecuteReader();
                int count = 0;
                Console.WriteLine($"<-------Available Rooms------->");
                while (rdr.Read())
                {

                    Console.WriteLine($"+ Room #:{rdr[0]} Capacity:{rdr[1]}");
                    count++;
                }
                Console.WriteLine($"<---Total Available Rooms: {count}--->");
                rdr.Close();
                MainMenu(conn);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error: Unable to retrieve available rooms");
                throw;
            }
        }
        else
        {
            Console.WriteLine("Error: Unable to connect to the database");
        }
    }

    static void CheckIn(DatabaseConnect conn)
    {
        Console.WriteLine("Let's Check-In");
        Console.WriteLine("Enter Room Number: ");
        string? roomNumber = Console.ReadLine();
        Console.WriteLine("Enter Customer Name: ");
        string? custName = Console.ReadLine();
        if (conn.GetConnection().State == ConnectionState.Open)
        {


        }


    }

    static void ShowReservedRooms(DatabaseConnect conn)
    {
        if (conn.GetConnection().State == ConnectionState.Open)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("GetReservedRooms", conn.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader rdr = cmd.ExecuteReader();
                int count = 0;
                Console.WriteLine($"<-------Reserved Room(s)------->");
                while (rdr.Read())
                {
                    Console.WriteLine($"+ Room #:{rdr[0]} Customer:{rdr[1]}");
                    count++;
                }
                Console.WriteLine($"<----Number of Reserved Rooms: {count}---->");
                rdr.Close();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error: Unable to retrieve available rooms");
                throw;
            }
        }
        else
        {
            Console.WriteLine("Error: Unable to connect to the database");
        }
    }

    static void CheckOut()
    {
        Console.WriteLine("CheckOut");


    }

    static void LogOut()
    {
        Console.WriteLine("LogOut");



    }

}
