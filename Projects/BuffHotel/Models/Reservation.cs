namespace BuffHotel.Models
{

   // Represents a model replica of the Reservation table in the database.
   public class Reservation
   {
      public int ReservationId { get; set; }
      public int RoomNumber { get; set; }
      public string? CustomerName { get; set; }
      public string? Status { get; set; }
      public DateTime CheckInDate { get; set; }
      public DateTime? CheckOutDate { get; set; }
   }
}