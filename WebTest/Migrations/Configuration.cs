using WebTest.Core.Models;

namespace WebTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebTest.Core.Data.BookingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebTest.Core.Data.BookingContext context)
        {
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

            context.Bookings.AddOrUpdate(
                p => new {p.BookingId, p.PersonId, p.ResourceId, p.Start, p.Stop},
                new Booking
                    {
                        BookingId = 4,
                        PersonId = 1,
                        ResourceId = 1,
                        Start = DateTime.Parse("2012-01-01"),
                        Stop = DateTime.Parse("2012-02-02")
                    },
                new Booking
                    {
                        PersonId = 1,
                        ResourceId = 2,
                        Start = DateTime.Parse("2012-01-01"),
                        Stop = DateTime.Parse("2012-02-02")
                    },
                new Booking
                    {
                        PersonId = 1,
                        ResourceId = 3,
                        Start = DateTime.Parse("2012-01-01"),
                        Stop = DateTime.Parse("2012-02-02")
                    },
                new Booking
                    {
                        PersonId = 1,
                        ResourceId = 1,
                        Start = DateTime.Parse("2012-01-01"),
                        Stop = DateTime.Parse("2012-02-02")
                    },
                new Booking
                    {
                        PersonId = 1,
                        ResourceId = 2,
                        Start = DateTime.Parse("2012-01-01"),
                        Stop = DateTime.Parse("2012-02-02")
                    },
                new Booking
                    {
                        PersonId = 1,
                        ResourceId = 3,
                        Start = DateTime.Parse("2012-01-01"),
                        Stop = DateTime.Parse("2012-02-02")
                    },
                new Booking
                    {
                        PersonId = 1,
                        ResourceId = 1,
                        Start = DateTime.Parse("2012-01-01"),
                        Stop = DateTime.Parse("2012-02-02")
                    },
                new Booking
                    {
                        PersonId = 1,
                        ResourceId = 2,
                        Start = DateTime.Parse("2012-01-01"),
                        Stop = DateTime.Parse("2012-02-02")
                    },
                new Booking
                    {
                        PersonId = 1,
                        ResourceId = 3,
                        Start = DateTime.Parse("2012-01-01"),
                        Stop = DateTime.Parse("2012-02-02")
                    }
                );
        }
    }
}
