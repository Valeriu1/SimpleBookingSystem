using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simple_booking_system.DataAccess;
using Simple_booking_system.DataValidation;
using Simple_booking_system.Model;

namespace Simple_booking_system.Data
{
    public class BookingService : IBookingService
    {
        
        private BookingDbContext context;

        public BookingService(BookingDbContext context)
        {
            this.context = context;
        }
        
        public async Task<bool> AddBookingAsync(Booking booking)
        {

            List<Booking> bookingsWithSameResource = await GetBookingsByResourceId(booking.ResourceId);
            Resource resourceToBook = context.Resources.FirstOrDefault(resource => resource.Id == booking.ResourceId);

            bool valid = new BookingValidate().ValidateBooking(bookingsWithSameResource, booking, resourceToBook);

            if (valid)
            {
                context.Bookings.Add(booking);
                await SaveChanges();
                Console.WriteLine("EMAIL SENT TO admin@admin.com FOR CREATED BOOKING WITH ID " + booking.Id);
            }

            return valid;

        }
        
        
        public async Task<List<Booking>> GetBookingsByResourceId(int id)
        {
            return context.Bookings.Where(b => b.ResourceId == id).ToList();
            
        }
        
        private async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}