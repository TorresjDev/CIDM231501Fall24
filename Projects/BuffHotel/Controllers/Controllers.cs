using BuffHotel.Models;
using Utilities;

namespace BuffHotel.Controllers;
/* HotelController class is used to handle all the database communication with  user interaction to the Buff Hotel System.
 * This class contains:
   * 3 fields: _dbConn, _rooms, and _reservations.
   * 1 constructor: HotelController
   * 5 methods: MainMenu, CheckIn, CheckOut, LogOut, and RefreshData.
 *
 */
public class HotelController
{
   // _dbConn is used to represent the a connection to the database.
   private DBConnect _dbConn;

   // _rooms represents a list of Room objects.
   private List<Room> _rooms;

   // _reservations represents a list of Reservation objects.
   private List<Reservation> _reservations;

   // HotelController constructor initializes the _dbConn, _rooms, and _reservations fields using dbConn parameter and Service methods.
   public HotelController(DBConnect dbConn)
   {
      _dbConn = dbConn;
      _rooms = Service.GetRooms(dbConn);
      _reservations = Service.GetReservations(dbConn);
   }

   // MainMenu method displays the main menu options parents all user interaction with the Buff Hotel System.
   public void MainMenu()
   {
      string? option;

      do
      {
         Console.WriteLine("\n***********************************************");
         Console.WriteLine("---> Please select a # option from the menu <---");
         Console.WriteLine(" 1. Show Available Rooms");
         Console.WriteLine(" 2. Check-In");
         Console.WriteLine(" 3. Show Active Reservations");
         Console.WriteLine(" 4. Check-Out");
         Console.WriteLine(" 5. Show All Rooms");
         Console.WriteLine(" 6. Show Completed Reservations");
         Console.WriteLine(" 7. Show All Reservations");
         Console.WriteLine(" 8. Log Out");
         Console.WriteLine("***********************************************");
         option = Console.ReadLine()?.Trim();

         switch (option)
         {
            case "1":
               ShowAvailableRooms();
               break;
            case "2":
               CheckIn();
               break;
            case "3":
               ShowActiveReservations();
               break;
            case "4":
               CheckOut();
               break;
            case "5":
               ShowAllRooms();
               break;
            case "6":
               ShowCompletedReservations();
               break;
            case "7":
               ShowAllReservations();
               break;
            case "8":
               LogOut();
               break;
            default:
               Console.WriteLine("\nInvalid Option");
               Console.WriteLine(">>> Press any key to return to the main menu...");
               Console.ReadKey();
               break;
         }
      } while (option != "8");
   }

   // CheckIn method is used to check-in a customer to a room in the Buff Hotel System DB.
   private void CheckIn()
   {
      Service.CheckIn(_dbConn, _rooms);
      RefreshData();
   }

   // CheckOut method is used to check-out a customer from a room in the Buff Hotel System DB.
   private void CheckOut()
   {
      Service.CheckOut(_dbConn, _rooms, _reservations);
      RefreshData();
   }

   // ShowAvailableRooms method is used to check-in a customer to a room in the Buff Hotel System DB.
   private void ShowAvailableRooms()
   {
      if (_rooms.Count == 0 || _rooms == null)
      { // check if the list of rooms is empty
         Console.WriteLine("No available rooms at the moment");
         return;
      }
      MethodHelper.FilterRoomsByStatus(_rooms, "Available Room(s)", true);
      Console.WriteLine("\n>>> Press any key to continue...");
      Console.ReadKey();
   }

   // ShowActiveReservations method is used to display all active reservations in the Buff Hotel System DB.
   private void ShowActiveReservations()
   {
      if (_reservations.Count == 0 || _reservations == null)
      {
         Console.WriteLine("Sorry, no reserved rooms at the moment");
         return;
      }
      MethodHelper.FilterReservationsByStatus(_reservations, "Active Reservation(s)", "Active");

      // Console.WriteLine("\n<-------Reserved Room(s)------->");

      // foreach (Reservation resv in _reservations)
      // {
      //    Console.WriteLine($"+ Room #:{resv.RoomNumber} Customer:{resv.CustomerName}");
      // }

      Console.WriteLine("\n>>> Press any key to continue...");
      Console.ReadKey(); RefreshData();
   }

   private void ShowAllRooms()
   {
      if (_rooms.Count == 0 || _rooms == null)
      {
         Console.WriteLine("No rooms available at the moment");
         return;
      }

      Console.WriteLine("\n<-------All Room(s)------->");
      MethodHelper.FilterRoomsByStatus(_rooms, "Available Room(s)", true);
      MethodHelper.FilterRoomsByStatus(_rooms, "Reserved Room(s)", false);
      Console.WriteLine(">>> Press any key to continue...");
      Console.ReadKey();
   }


   // ShowCompletedReservations method is used to display all completed reservations in the Buff Hotel System DB.
   private void ShowCompletedReservations()
   {
      if (_reservations.Count == 0 || _reservations == null)
      {
         Console.WriteLine("No reservations found at the moment");
         return;
      }
      MethodHelper.FilterReservationsByStatus(_reservations, "Completed Reservation(s)", "Completed");
      Console.WriteLine("\n>>> Press any key to continue...");
      Console.ReadKey();
   }

   // ShowAllReservations method is used to display all reservations in the Buff Hotel System DB.
   private void ShowAllReservations()
   {
      if (_reservations.Count == 0 || _reservations == null)
      {
         Console.WriteLine("No reservations found at the moment");
         return;
      }
      Console.WriteLine("\n<-------All Reservation(s)------->");
      MethodHelper.FilterReservationsByStatus(_reservations, "Active Reservation(s)", "Active");
      MethodHelper.FilterReservationsByStatus(_reservations, "Completed Reservation(s)", "Completed");

      Console.WriteLine("\n>>> Press any key to continue...");
      Console.ReadKey();
   }

   // LogOut method is used to log out the user from the Buff Hotel System DB.
   private void LogOut()
   {
      Service.LogOut(_dbConn);
      Console.WriteLine("Goodbye!");
   }

   // RefreshData method is used to refresh the _rooms and _reservations fields with the latest data from the Buff Hotel System DB.
   private void RefreshData()
   {
      _rooms = Service.GetRooms(_dbConn);
      _reservations = Service.GetReservations(_dbConn);
   }
}