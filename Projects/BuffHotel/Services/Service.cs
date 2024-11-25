using System.Data;
using MySql.Data.MySqlClient;

public class Service
{
   public static void ShowAvailableRooms(DBConnect conn)
   {
      if (conn.GetConnection().State == ConnectionState.Open)
      { // Check if the connection is open before executing the query
         try
         {
            MySqlCommand cmd = new MySqlCommand("GetAvailableRooms", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rdr = cmd.ExecuteReader();
            int count = 0;
            Console.WriteLine($"\n<-------Available Rooms------->");
            while (rdr.Read())
            {
               Console.WriteLine($"+ Room #:{rdr[0]} Capacity:{rdr[1]}");
               count++;
            }
            Console.WriteLine($"<---Total count of Available Rooms: {count}--->");
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
      Console.WriteLine("\n>>> Press any key to continue...");
      Console.ReadKey();
   }

   public static void CheckIn(DBConnect conn)
   {
      Console.WriteLine("\nLet's Check-In");
      Console.WriteLine("Enter Room Number: ");

      int roomNumber;
      while (!int.TryParse(Console.ReadLine()?.Trim(), out roomNumber))
      {
         Console.WriteLine("Invalid Room Number. Please enter a valid room number");
      }

      Console.WriteLine("Enter Customer Name: ");
      string? custName = Console.ReadLine()?.Trim().ToLower();

      Console.WriteLine("Enter Customer Email: ");
      string? custEmail = Console.ReadLine()?.Trim().ToLower();

      if (conn.GetConnection().State == ConnectionState.Open)
      {
         try
         {
            MySqlCommand cmd = new MySqlCommand("CreateReservation", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_RoomNumber", roomNumber);
            cmd.Parameters.AddWithValue("@p_CustomerName", custName);
            cmd.Parameters.AddWithValue("@p_CustomerEmail", custEmail);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Check-In Successful!");
         }
         catch (System.Exception)
         {
            Console.WriteLine("Error: Unable to check-in");
            throw;
         }
      }
      else
      {
         Console.WriteLine("Error: Unable to connect to the database");
      }
   }

   public static void ShowReservedRooms(DBConnect conn)
   {
      if (conn.GetConnection().State == ConnectionState.Open)
      {
         try
         {
            MySqlCommand cmd = new MySqlCommand("GetReservedRoomsByActive", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rdr = cmd.ExecuteReader();
            int count = 0;
            Console.WriteLine($"\n<-------Reserved Room(s)------->");
            while (rdr.Read())
            {
               Console.WriteLine($"+ Room #:{rdr[0]} Customer:{rdr[1]}");
               count++;
            }
            Console.WriteLine($"<----Total count of Reserved Rooms: {count}---->");
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
      Console.WriteLine("\n>>> Press any key to continue...");
      Console.ReadKey();
   }

   public static void CheckOut(DBConnect conn)
   {
      Console.WriteLine("\n Check-Out Menu");
      Console.WriteLine("Enter Room Number: ");
      int roomNumber = Convert.ToInt32(Console.ReadLine()?.Trim());
      if (conn.GetConnection().State == ConnectionState.Open)
      {
         try
         {
            MySqlCommand cmd = new MySqlCommand("GetReservedRoomById", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_RoomNumber", roomNumber);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (!rdr.HasRows)
            {
               Console.WriteLine($"Sorry, Room {roomNumber} is not currently reserved");
               return;
            }
            else
            {
               while (rdr.Read())
               {
                  Console.WriteLine($"+ Room #:{rdr[0]} Customer:{rdr[1]}");
               }
               rdr.Close();
               Console.WriteLine("Please confirm customer info and input y to confirm check-out OR input any key to cancel");
               string? confirm = Console.ReadLine()?.Trim().ToLower();
               if (confirm == "y")
               {
                  MySqlCommand cmd2 = new MySqlCommand("CheckOutReservation", conn.GetConnection());
                  cmd2.CommandType = CommandType.StoredProcedure;
                  cmd2.Parameters.AddWithValue("@p_RoomNumber", roomNumber);
                  cmd2.ExecuteNonQuery();
                  Console.WriteLine("Check-Out Successful!");
               }
               else
               {
                  Console.WriteLine("Check-Out Cancelled");
                  Console.WriteLine("\n>>> Press any key to continue...");
                  Console.ReadKey();
                  return;
               }
            }
         }
         catch (System.Exception)
         {
            Console.WriteLine("Error: Unable to check-out");
            throw;
         }
      }
      else
      {
         Console.WriteLine("Error: Unable to connect to the database");
      }
   }

   public static void LogOut()
   {
      Console.WriteLine("LogOut");



   }
}