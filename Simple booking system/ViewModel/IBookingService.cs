using System.Collections.Generic;
using System.Threading.Tasks;
using Simple_booking_system.Model;

namespace Simple_booking_system.Data
{
    public interface IBookingService
    {
        Task<bool> AddBookingAsync(Booking booking);
        Task<List<Booking>> GetBookingsByResourceId(int id);
        Task<List<Booking>> GetBookings();
    }
}