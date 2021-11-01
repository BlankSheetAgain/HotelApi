using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models
{
    public class Guest
    {
        public Guid Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birth { get; set; }
        public string Passport { get; set; }
        public string Mobile { get; set; }
    }
}
