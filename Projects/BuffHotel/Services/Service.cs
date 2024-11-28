using System.Data;
using MySql.Data.MySqlClient;
using BuffHotel.Models; // Add this line to include the Room class

public class Service
{
   public static List<AvailableRoom> GetAvRooms(DBConnect conn)
   {
      List<AvailableRoom> avRooms = new List<AvailableRoom>();
      if (conn.GetConnection().State == ConnectionState.Open)
      {
         try
         {
            MySqlCommand cmd = new MySqlCommand("GetAvailableRooms", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
               AvailableRoom room = new AvailableRoom();
               room.RoomNumber = Convert.ToInt32(rdr[0]);
               room.Capacity = Convert.ToInt32(rdr[1]);
               avRooms.Add(room);
            }
            rdr.Close();
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: Unable to retrieve available rooms\nError: {ex.Message}");
            throw;
         }
      }
      else
      {
         Console.WriteLine("Error: Unable to connect to the database");
      }
      return avRooms;
   }

   public static List<ReservedRoom> GetResRooms(DBConnect conn)
   {
      List<ReservedRoom> resRooms = new List<ReservedRoom>();
      if (conn.GetConnection().State == ConnectionState.Open)
      {
         try
         {
            MySqlCommand cmd = new MySqlCommand("GetReservedRoomsByActive", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
               ReservedRoom room = new ReservedRoom();
               room.RoomNumber = Convert.ToInt32(rdr[0]);
               room.CustomerName = Convert.ToString(rdr[1]) ?? string.Empty;
               resRooms.Add(room);
            }
            rdr.Close();
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: Unable to retrieve reserved rooms\nError: {ex.Message}");
            throw;
         }
      }
      else
      {
         Console.WriteLine("Error: Unable to connect to the database");
      }
      return resRooms;
   }

   public static void FilterAvailableRooms(List<AvailableRoom> avRms)
   {
      Console.WriteLine("\n<-------Available Room(s)------->");
      foreach (AvailableRoom room in avRms)
      {
         Console.WriteLine($"+ Room #:{room.RoomNumber} Capacity:{room.Capacity}");
      }
      Console.WriteLine("\n>>> Press any key to continue...");
      Console.ReadKey();
   }

   public static void CheckIn(DBConnect conn, List<AvailableRoom> avRms)
   {
      Console.WriteLine("\nLet's Check-In");
      Console.WriteLine("Enter Room Number: ");

      int roomNumber = Convert.ToInt32(Console.ReadLine()?.Trim());
      // need condition to iterate through existing available rooms
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
         catch (Exception ex)
         {
            Console.WriteLine($"Error: Unable to check-in\nError: {ex.Message}");
            throw;
         }
      }
      else
      {
         Console.WriteLine("Error: Unable to connect to the database");
      }
   }

   public static void FilterReservedRooms(List<ReservedRoom> resRms)
   {
      Console.WriteLine("\n<-------Reserved Room(s)------->");
      foreach (ReservedRoom room in resRms)
      {
         Console.WriteLine($"+ Room #:{room.RoomNumber} Customer:{room.CustomerName}");
      }
      Console.WriteLine("\n>>> Press any key to continue...");
      Console.ReadKey();
   }

   public static void CheckOut(DBConnect conn, List<ReservedRoom> resRms)
   {
      Console.WriteLine("\n Check-Out Menu");
      Console.WriteLine("Enter Room Number: ");
      int roomNumber = Convert.ToInt32(Console.ReadLine()?.Trim());
      // need condition to iterate through existing reserved rooms
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
         catch (Exception ex)
         {
            Console.WriteLine($"Error: Unable to check-out\nError: {ex.Message}");
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