using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_1.Models
{
    public class Hotel

    {
        public int Id { get; set; }
       public int Description { get; set; }
        public string Name { get; set; }
        public List<string> MealTypes { get; set; }
        public List<RoomType> RoomTypes { get; set; }

    }
}