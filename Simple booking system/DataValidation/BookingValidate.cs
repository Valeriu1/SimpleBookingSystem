using System;
using System.Collections.Generic;
using Simple_booking_system.Model;

namespace Simple_booking_system.DataValidation
{
    public class BookingValidate
    {
        public bool ValidateBooking(List<Booking> bookings, Booking bookingToValidate, Resource resourceToBook)
        {
            if (bookings == null || bookingToValidate == null || resourceToBook == null)
            {
                return false;
            }

            if (bookingToValidate.DateFrom > bookingToValidate.DateTo)
            {
                return false;
            }

            int bookedQuantity = 0;
            foreach (var booking in bookings)
            {
                if (booking.ResourceId == bookingToValidate.ResourceId)
                {
                    if(DateTimeOverlap(booking.DateFrom, booking.DateTo, bookingToValidate.DateFrom, bookingToValidate.DateTo))
                    {
                        bookedQuantity += booking.BookedQuantity;
                    }
                }
            }

            int remainingQuantity = resourceToBook.Quantity - bookedQuantity;
            return remainingQuantity - bookingToValidate.BookedQuantity >= 0;
        }


        public bool DateTimeOverlap(DateTime firstDateFrom, DateTime firstDateTo, DateTime secondDateFrom,
            DateTime secondDateTo)
        {
            if (firstDateFrom <= secondDateTo && firstDateTo >= secondDateFrom)
            {
                return true;
            }

            return false;
        }
    }
}