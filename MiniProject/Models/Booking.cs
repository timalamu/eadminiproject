using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProject.Models
{
    public class Booking
    {
        [Key]
        [Required]
        [Display(Name = "Booking Code")]
        public int BookingID { get; set; }

        [Required]
        [Display(Name = "Account No.")]
        public int AccountID { get; set; }

        [Required]
        [Display(Name = "Date of Booking")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBooking { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        [StringLength(60, ErrorMessage = "Name cannot be longer than 60 characters.")]
        public string PassengerName { get; set; }

        [Required]
        [Display(Name = "Date of Departure")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DepartureDate { get; set; }

        [Required]
        [Display(Name = "Return Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }

        [Required]
        [Display(Name = "Number of Passenger(s)")]
        [Range(1, 10)]
        public int NumberOfPassengers { get; set; }

        [Required]
        [Display(Name = "Departure Airport")]
        public string PointOfOrigin { get; set; }

        [Required]
        [Display(Name = "Destination")]
        public string Destination { get; set; }

        [Required]
        [Display(Name = "Flight Duration")]
        public int FlightDuration { get; set; }

        public Customer Customer { get; set; }

    }

}