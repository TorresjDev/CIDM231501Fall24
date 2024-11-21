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
            Console.WriteLine($"<---Total Available Rooms: {count}--->");
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

   public static void CheckIn(DBConnect conn)
   {
      Console.WriteLine("\nLet's Check-In");
      Console.WriteLine("Enter Room Number: ");
      int? roomNumber = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter Customer Name: ");
      string? custName = Console.ReadLine();

      Console.WriteLine("Enter Customer Email: ");
      string? custEmail = Console.ReadLine();

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
   }

   public static void ShowReservedRooms(DBConnect conn)
   {
      if (conn.GetConnection().State == ConnectionState.Open)
      {
         try
         {
            MySqlCommand cmd = new MySqlCommand("GetReservedRooms", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rdr = cmd.ExecuteReader();
            int count = 0;
            Console.WriteLine($"\n<-------Reserved Room(s)------->");
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

   public static void CheckOut()
   {
      Console.WriteLine("CheckOut");


   }

   public static void LogOut()
   {
      Console.WriteLine("LogOut");



   }
}