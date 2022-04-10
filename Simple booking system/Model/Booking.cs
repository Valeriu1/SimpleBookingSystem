using System;
using System.ComponentModel.DataAnnotations;

namespace Simple_booking_system.Model
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateFrom{ get; set; } = DateTime.Now;
        public DateTime DateTo { get; set; } = DateTime.Now.AddDays(1);
        public int BookedQuantity { get; set; }
        public int ResourceId { get; set; }
        
        
        
    }
}