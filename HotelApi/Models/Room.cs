using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public List<Category> Categories { get; set; }
         
        
    }
}
