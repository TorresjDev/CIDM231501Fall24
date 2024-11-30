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
      public required string CustomerName { get; set; } //using required to satisfy the non-nullable reference type
   }

   public class Room
   {
      public int RoomNumber { get; set; }
      public int Capacity { get; set; }
      public byte IsAvailable { get; set; }
   }
}