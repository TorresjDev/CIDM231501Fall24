namespace BuffHotel.Models
{
   public class AvailableRoom
   {
      // public static List<Room> Rooms = new List<Room>();
      public int RoomNumber { get; set; }
      public int Capacity { get; set; }
   }

   public class ReservedRoom
   {
      public int RoomNumber { get; set; }
      public string CustomerName { get; set; }
   }

   public class Room
   {
      public int RoomNumber { get; set; }
      public int Capacity { get; set; }
      public byte IsAvailable { get; set; }
   }
}