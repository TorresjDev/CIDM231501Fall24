using BuffHotel.Models;

namespace Utilities
{
   public class MethodHelper
   {
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
      public static void MainMenu(DBConnect conn)
      {
         string? option = string.Empty;
         List<AvailableRoom> avbRooms = new List<AvailableRoom>();
         List<ReservedRoom> resRooms = new List<ReservedRoom>();

         if (avbRooms.Count == 0 && resRooms.Count == 0)
         {
            avbRooms = Service.GetAvRooms(conn);
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
                  Service.LogOut(conn);
                  break;
               default:
                  Console.WriteLine("\nInvalid Option");
                  Console.WriteLine(">>> Press any key to return to the main menu...");
                  Console.ReadKey();
                  break;
            }
         } while (option != "5");
      }

      public static int ValRoomNumber()
      {
         int roomNumber;
         while (!int.TryParse(Console.ReadLine()?.Trim(), out roomNumber))
         {
            Console.WriteLine("Invalid Room Number\n\n>>>Please enter a valid room number");
         }
         return roomNumber;
      }
   }
}