using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProject.Models
{
   
    public class CustomerDetailsDto
    {
        [Key]
        [Required]
        [Display(Name = "Account No.")]
        public int AccountID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "First name cannot be longer than 30 characters.")]
        public string FirstMidName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "First name cannot be longer than 30 characters.")]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNo { get; set; }

        [Required]
        [Display(Name = "Number of Passenger(s)")]
        [Range(1, 10)]
        public int NumberOfPassengers { get; set; }

        [Display(Name = "Frequent Destination")]
        public string FrequentDestination { get; set; }

        [Display(Name = "Destination Zone")]
        public DestinationZone DestinationZone { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}