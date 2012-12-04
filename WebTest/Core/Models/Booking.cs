using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Core.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int PersonId { get; set; }
        public int ResourceId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
    }
}