using HotelReservation.Entities;
using HotelReservation.Entities.Exceptions;

namespace HotelReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("check-in date (YYYY-MM-DD): ");
                DateTime checkinDate = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out date (YYYY-MM-DD): ");
                DateTime checkoutDate = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkinDate, checkoutDate);
                Console.WriteLine(reservation);

                Console.WriteLine("Enter the data to update the reservation:");
                Console.Write("check-in date (YYYY-MM-DD): ");
                checkinDate = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out date (YYYY-MM-DD): ");
                checkoutDate = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkinDate, checkoutDate);
                Console.WriteLine(reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}