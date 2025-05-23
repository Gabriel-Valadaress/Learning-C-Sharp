using System.Globalization;
using CarRent_WithoutInterface.Entities.Exceptions;

namespace CarRent_WithoutInterface.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            if(start >= finish)
            {
                throw new DomainException("Return date must be after the pickup date.");
            }
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
