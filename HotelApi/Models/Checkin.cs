using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models
{
    public class Checkin
    {
        public Guid Id { get; set; }
        public Guest GuestId { get; set; }
        public Room RoomId { get; set; }
        public bool Check_in { get; set; }
        public bool Check_out { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
