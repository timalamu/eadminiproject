using MiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject.DTOs
{
    public class CustomerDto
    {
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNo { get; set; }
        public int NumberOfPassengers { get; set; }
        public string FrequentDestination { get; set; }
        public DestinationZone DestinationZone { get; set; }

        public List<Booking> Bookings { get; set; }

    }
}