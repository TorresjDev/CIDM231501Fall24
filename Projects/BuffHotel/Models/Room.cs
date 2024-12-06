namespace BuffHotel.Models
{
   // Represents a model of a room that is available for reservation
   public class AvailableRoom
   {
      public int RoomNumber { get; set; }
      public int Capacity { get; set; }
   }

   // Represents a model of a room that is reserved by a customer
   public class ReservedRoom
   {
      public int RoomNumber { get; set; }
      public required string CustomerName { get; set; } //using required to satisfy the non-nullable reference type
   }

}