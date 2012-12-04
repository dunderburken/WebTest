using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebTest.Core.Models;

namespace WebTest.Core.Data
{
    public class BookingContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
    }
}