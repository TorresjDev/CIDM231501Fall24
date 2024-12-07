namespace BuffHotel.Models
{

   // Represents a model replica of the Room table in the database.
   public class Room
   {
      public int RoomNumber { get; set; }
      public int Capacity { get; set; }
      public bool Status { get; set; }
   }
}