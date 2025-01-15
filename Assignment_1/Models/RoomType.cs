using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_1.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public decimal PricePerNight { get; set; }
        public string Features { get; set; }
    }
}