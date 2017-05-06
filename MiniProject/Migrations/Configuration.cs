namespace MiniProject.Migrations
{
    using MiniProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MiniProject.Models.MiniProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MiniProject.Models.MiniProjectContext context)
        {
            context.Customers.AddOrUpdate(c => c.AccountID,
                   new Customer { FirstMidName = "Tim", LastName = "Alamu", Address = "Newbridge", DateOfBirth = DateTime.FromOADate(1900 - 10 - 25), PhoneNo = "023", NumberOfPassengers = 1, FrequentDestination = "Dublin", DestinationZone = DestinationZone.Europe },
                   new Customer { FirstMidName = "Bob", LastName = "John", Address = "Tallaght", DateOfBirth = DateTime.FromOADate(2017 - 10 - 25), PhoneNo = "0233434", NumberOfPassengers = 1, FrequentDestination = "Cork", DestinationZone = DestinationZone.Europe },
                   new Customer { FirstMidName = "Phil", LastName = "Alamu", Address = "Newbridge", DateOfBirth = DateTime.FromOADate(1900 - 10 - 25), PhoneNo = "023", NumberOfPassengers = 1, FrequentDestination = "Dublin", DestinationZone = DestinationZone.Europe },
                   new Customer { FirstMidName = "Sam", LastName = "John", Address = "Tallaght", DateOfBirth = DateTime.FromOADate(2017 - 10 - 25), PhoneNo = "0233434", NumberOfPassengers = 1, FrequentDestination = "Cork", DestinationZone = DestinationZone.Europe }

                               );

            context.Bookings.AddOrUpdate(b => b.BookingID,
                   new Booking { BookingID = 003, DateOfBooking = DateTime.FromOADate(1900 - 10 - 25), PassengerName = "Alamu", DepartureDate = DateTime.FromOADate(1900 - 10 - 25), ReturnDate = DateTime.FromOADate(1900 - 10 - 25), NumberOfPassengers = 2, PointOfOrigin = "Dublin", Destination = "London", FlightDuration = 2, AccountID = 1 },
                   new Booking { BookingID = 004, DateOfBooking = DateTime.FromOADate(1900 - 11 - 25), PassengerName = "Lee Harvey", DepartureDate = DateTime.FromOADate(2017 - 10 - 25), ReturnDate = DateTime.FromOADate(1900 - 11 - 25), NumberOfPassengers = 2, PointOfOrigin = "London", Destination = "Bilbao", FlightDuration = 2, AccountID = 2 },
                   new Booking { BookingID = 006, DateOfBooking = DateTime.FromOADate(1900 - 10 - 25), PassengerName = "Alamu", DepartureDate = DateTime.FromOADate(1900 - 10 - 25), ReturnDate = DateTime.FromOADate(1900 - 10 - 25), NumberOfPassengers = 2, PointOfOrigin = "Dublin", Destination = "London", FlightDuration = 2, AccountID = 1 },
                   new Booking { BookingID = 005, DateOfBooking = DateTime.FromOADate(2000 - 11 - 25), PassengerName = "Lee Harvey", DepartureDate = DateTime.FromOADate(20-10-2015), ReturnDate = DateTime.FromOADate(1900 - 11 - 25), NumberOfPassengers = 2, PointOfOrigin = "London", Destination = "Bilbao", FlightDuration = 2, AccountID = 3 }
                    );

            context.CustomerBookings.AddOrUpdate(c => c.TableID,
                   new CustomerBooking { TableID = 10, BookingID = 003, AccountID = 2 },
                   new CustomerBooking { TableID = 11, BookingID = 004, AccountID = 1 },
                   new CustomerBooking { TableID = 10, BookingID = 003, AccountID = 2 },
                   new CustomerBooking { TableID = 11, BookingID = 004, AccountID = 1 }

                   );

            //  This method will be called after migrating to the latest version.

                   //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
                   //  to avoid creating duplicate seed data. E.g.
                   //
                   //    context.People.AddOrUpdate(
                   //      p => p.FullName,
                   //      new Person { FullName = "Andrew Peters" },
                   //      new Person { FullName = "Brice Lambson" },
                   //      new Person { FullName = "Rowan Miller" }
                   //    );
                   //
        }
    }
}
