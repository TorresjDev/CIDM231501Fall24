namespace BuffHotel.Models
{
   public class Room
   {
      public static List<Room> Rooms = new List<Room>();
      public int RoomNumber { get; set; }
      public int Capacity { get; set; }
   }
}