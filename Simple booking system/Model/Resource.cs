using System;
using System.ComponentModel.DataAnnotations;

namespace Simple_booking_system.Model

{
    public class Resource
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        
    }
}