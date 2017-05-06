using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProject.Models
{
    public class CustomerBooking
    {
        [Key]
        [Required]
        [Display(Name = "ID")]
        public int TableID { get; set; }

        [Required]
        [Display(Name = "Booking Code")]
        public virtual int BookingID { get; set; }

        [Required]
        [Display(Name = "Account No.")]
        public virtual int AccountID { get; set; }
    }
}