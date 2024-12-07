using System.Data;
using MySql.Data.MySqlClient;
using BuffHotel.Models;
using Utilities;

// Service class contains methods(services) to interact with the database.
public class Service
{
   // GetRooms method retrieves all available rooms using parameter conn to interact with the database.
   public static List<Room> GetRooms(DBConnect conn)
   {
      List<Room> rms = new List<Room>();

      if (!conn.EnsureConnection())
      {
         return rms;
      }

      try
      { // invokes the stored procedure to retrieve all rooms in the hotel.
         MySqlCommand cmd = new MySqlCommand("GetAllRooms", conn.GetConnection());
         cmd.CommandType = CommandType.StoredProcedure;
         MySqlDataReader rdr = cmd.ExecuteReader();
         while (rdr.Read())
         { // assigns the retrieved data to the Room object and adds it to the rms list.
            Room rm = new Room();
            rm.RoomNumber = Convert.ToInt32(rdr[0]);
            rm.Capacity = Convert.ToInt32(rdr[1]);
            rm.Status = Convert.ToBoolean(rdr[2]);
            rms.Add(rm);
         }
         rdr.Close();
      }
      catch (Exception ex)
      {
         Console.WriteLine($"Error: Unable to retrieve available rooms\nError: {ex.Message}");
         throw;
      }

      return rms;
   }

   // GetReservations method retrieves all reserved rooms using parameter conn to interact with the database.
   public static List<Reservation> GetReservations(DBConnect conn)
   {
      List<Reservation> reservations = new List<Reservation>();

      if (!conn.EnsureConnection())
      {
         return reservations;
      }

      try
      { // invokes the stored procedure to retrieve all reserved rooms in the hotel.
         MySqlCommand cmd = new MySqlCommand("GetAllReservations", conn.GetConnection());
         cmd.CommandType = CommandType.StoredProcedure;
         MySqlDataReader rdr = cmd.ExecuteReader();
         while (rdr.Read())
         { // assigns the retrieved data to the Reservation object and adds it to the reservations list.
            Reservation rsv = new Reservation();
            rsv.ReservationId = Convert.ToInt32(rdr[0]);
            rsv.RoomNumber = Convert.ToInt32(rdr[1]);
            rsv.CustomerName = Convert.ToString(rdr[2]) ?? string.Empty;
            rsv.Status = Convert.ToString(rdr[3]) ?? string.Empty;
            rsv.CheckInDate = Convert.ToDateTime(rdr[4]);
            rsv.CheckOutDate = rdr.IsDBNull(5) ? null : Convert.ToDateTime(rdr[5]);
            reservations.Add(rsv);
         }
         rdr.Close();
      }
      catch (Exception ex)
      {
         Console.WriteLine($"Error: Unable to retrieve reserved rooms\nError: {ex.Message}");
         throw;
      }
      return reservations;
   }

   // CheckIn method is used to check-in a customer using parameters conn, rms, and resRms to validate and interact with the database.
   public static void CheckIn(DBConnect conn, List<Room> rms)
   {
      Console.WriteLine("\nLet's Check-In");

      if (!conn.EnsureConnection())
      {
         return;
      }

      Console.WriteLine("Enter Room Capacity: ");
      int cap = MethodHelper.ValNumber("Capacity");
      while (!rms.Exists(r => r.Capacity == cap))
      { // logic to validate room number
         if (cap == 0)
         {
            return;
         }
         Console.WriteLine($"Sorry, we do not have rooms with capacity of {cap} available \n>>>Please enter a valid room capacity  or input 0 to cancel and return to the main menu");
         cap = MethodHelper.ValNumber("Capacity");
      }
      // logic to filter rooms based on capacity and status
      foreach (Room room in rms)
      {
         if (room.Capacity >= cap && room.Status == true)
         {// display rooms that meet the capacity requirement and are available
            Console.WriteLine($"+ Room #:{room.RoomNumber} Capacity:{room.Capacity}");
         }
      }
      Console.WriteLine("Enter Room Number: ");
      int rmNum = MethodHelper.ValNumber("Room");

      while (!rms.Exists(r => r.RoomNumber == rmNum))
      { // logic to validate room number
         if (rmNum == 0)
         {
            return;
         }
         Console.WriteLine("Invalid Room Number\n>>>Please enter a valid room number  or input 0 to cancel and return to the main menu");
         rmNum = MethodHelper.ValNumber("Room");
      }

      Console.WriteLine("Enter Customer Name: ");
      string? custName = Console.ReadLine()?.Trim();

      Console.WriteLine("Enter Customer Email: ");
      string? custEmail = Console.ReadLine()?.Trim();

      Console.WriteLine("Please confirm by inputting y to confirm check-in OR input any key to cancel");
      string? confirm = Console.ReadLine()?.Trim().ToLower();

      if (confirm == "y")
      {
         try
         { // invokes the stored procedure to check-in the customer
            MySqlCommand cmd = new MySqlCommand("CreateReservation", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_RoomNumber", rmNum);
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
         Console.WriteLine("Check-In was cancelled successfully!");
         Console.WriteLine("\n>>> Press any key to continue...");
         Console.ReadKey();
         return;
      }
   }

   // CheckOut method is used to check-out a customer using parameters conn, rms, and lRes to validate and interact with the database.
   public static void CheckOut(DBConnect conn, List<Room> rms, List<Reservation> lRes)
   {
      Console.WriteLine("\nLet's Check-Out");

      Reservation? res = new Reservation();

      if (!conn.EnsureConnection())
      { // if connection to the database is not successful return and stop the operation
         return;
      }

      Console.WriteLine("Enter Room Number:");
      int rmNum = MethodHelper.ValNumber("Room");
      while (!rms.Exists(r => r.RoomNumber == rmNum && r.Status == false))
      { // if room number does not exist display message and prompt user to enter a valid room number
         if (rmNum == 0)
         {
            return;
         }
         Console.WriteLine($"Sorry, Reservation for Room #: {rmNum} was not found\n>>> Please enter a valid room number reserved for check-out or input 0 to cancel and return to the main menu");
         rmNum = MethodHelper.ValNumber("Room");
      }

      // assign the room number to the res variable
      res = lRes.Find(r => r.RoomNumber == rmNum);
      Console.WriteLine($"+ Room #: {res?.RoomNumber} Customer: {res?.CustomerName}");
      try
      {
         Console.WriteLine("Please confirm customer info and input y to confirm check-out OR input any key to cancel");
         string? confirm = Console.ReadLine()?.Trim().ToLower();

         if (confirm == "y")
         { // if user confirms check-out execute the stored procedure to check-out the customer
            MySqlCommand cmd2 = new MySqlCommand("CheckOutReservation", conn.GetConnection());
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@p_RoomNumber", rmNum);
            cmd2.ExecuteNonQuery();
            Console.WriteLine("Check-Out Successful!");
         }
         else
         { // if user cancels check-out operation display message and return
            Console.WriteLine("Check-Out Cancelled");
            Console.WriteLine("\n>>> Press any key to continue...");
            Console.ReadKey();
            return;
         }
      }
      catch (Exception ex)
      {
         Console.WriteLine($"Error: Unable to check-out\nError: {ex.Message}");
         throw;
      }
   }

   // LogOut method is used to log out a user using parameter conn to interact with the database.
   public static void LogOut(DBConnect conn)
   { // invoke the CloseConnection method to close the connection to the database
      conn.CloseConnection();
      Console.WriteLine("Log out successful!");
   }
}