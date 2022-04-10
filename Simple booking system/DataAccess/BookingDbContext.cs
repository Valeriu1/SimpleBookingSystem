using Microsoft.EntityFrameworkCore;
using Simple_booking_system.Model;

namespace Simple_booking_system.DataAccess
{
    public class BookingDbContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Resource> Resources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Booking.db");
             
        }

       
    }
}