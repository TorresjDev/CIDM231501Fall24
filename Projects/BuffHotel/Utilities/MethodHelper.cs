using System.Globalization;
using BuffHotel.Models;

namespace Utilities
{
   public class MethodHelper
   {
      // Login method is used to validate user login credentials.
      public static bool Login(string uName, string pWord)
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

      // ValNumber method is used to validate user input for room number.
      public static int ValNumber(string header)
      {
         int rmNum;
         while (!int.TryParse(Console.ReadLine()?.Trim(), out rmNum))
         {
            Console.WriteLine($"Invalid {header} Number\n\n>>>Please enter a valid {header} number ");
         }
         return rmNum;
      }


      // FilterReservations method is used to filter reserved rooms from the list of reservations.
      public static void FilterReservationsByStatus(List<Reservation> rsv, string header, string status)
      {

         if (rsv.Count == 0 || rsv == null)
         {
            Console.WriteLine($"Sorry, no {header} at the moment");
            return;
         }

         int count = 0;
         Console.WriteLine($"\n<-------{header}------->");
         var filteredReservations = rsv.Where(r => r.Status == status);
         foreach (Reservation resv in filteredReservations)
         {
            if (resv.Status == "Completed")
            {
               Console.WriteLine($"+ Room #:{resv.RoomNumber} | Customer:{resv.CustomerName} - Check-In:{resv.CheckInDate} - Check-Out:{resv.CheckOutDate}");
               count++;
            }
            else
            {
               Console.WriteLine($"+ Room #:{resv.RoomNumber} | Customer:{resv.CustomerName} - Check-In:{resv.CheckInDate} ");
               count++;
            }
         }
         Console.WriteLine($"Number of {header}: {count}");
      }

      // FilterRoomsByStatus method is used to filter rooms based on status.
      public static void FilterRoomsByStatus(List<Room> rm, string header, bool status)
      {
         Console.WriteLine($"\n<-------{header}------->");
         int count = 0;

         var filteredRooms = rm.Where(r => r.Status == status);
         foreach (var room in filteredRooms)
         {
            Console.WriteLine($"+ Room #:{room.RoomNumber} Capacity:{room.Capacity}");
            count++;
         }
         Console.WriteLine($"Number of {header}: {count}");

      }
   }
}