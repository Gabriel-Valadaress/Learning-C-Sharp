using CarRent_WithoutInterface.Entities;
using CarRent_WithoutInterface.Entities.Exceptions;
using System.Globalization;
using System.Collections.Generic;
using CarRent_WithoutInterface.Services;

namespace CarRent_WithoutInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             A Brazilian car rental company charges an hourly rate for rentals 
            lasting up to 12 hours. However, if the rental duration exceeds 12 
            hours, the rental will be charged based on a daily rate. In addition 
            to the rental cost, a tax is added according to the country’s 
            regulations — in Brazil, this is 20% for amounts up to 100.00, or 15% 
            for amounts above 100.00.
            Write a program that reads the rental information (car model, start 
            and end time of the rental), as well as the hourly rate and the daily 
            rental rate. The program should then generate the invoice (containing 
            the rental amount, tax amount, and total payment amount) and display 
            this information on the screen. See the examples.
             */

            try
            {
                Console.WriteLine("Enter rental data:");
                Console.Write("Car model: ");
                string carModel = Console.ReadLine();
                Console.Write("Pickup (MM-DD-YYYY hh:mm): ");
                DateTime pickupDate = DateTime.ParseExact(Console.ReadLine(), "MM-dd-yyyy HH:mm",CultureInfo.InvariantCulture);
                Console.Write("Return (MM-DD-YYYY hh:mm): ");
                DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "MM-dd-yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Enter price per hour: ");
                 
                double priceHour = double.Parse(Console.ReadLine());
                Console.Write("Enter price per day: ");
                double priceDay = double.Parse(Console.ReadLine());

                CarRental carRental = new CarRental(pickupDate, returnDate, new Vehicle(carModel));

                RentalService rentalService = new RentalService(priceHour, priceDay);

                rentalService.ProcessInvoice(carRental);

                Console.WriteLine(carRental.Invoice);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Rental error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
