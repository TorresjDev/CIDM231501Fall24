namespace Utilities
{
   public class MethodHelper
   {
      public static int ValRoomNumber()
      {
         int roomNumber;
         while (!int.TryParse(Console.ReadLine()?.Trim(), out roomNumber))
         {
            Console.WriteLine("Invalid Room Number\n>>>Please enter a valid room number");
         }
         return roomNumber;
      }
   }
}