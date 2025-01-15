using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_1.Models
{
    public class BookingViewModel
    {
        public string IdType { get; set; }
        public string RoomType { get; set; }
        public string FullName { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public decimal Price { get; set; }
        public string Features { get; set; }
        public List<Hotel> Hotels { get; set; }
        public int SelectedHotelId { get; set; }
        public string SelectedMealType { get; set; }
        public List<string> MealTypes { get; set; }
        public List<string> RoomTypes { get; set; }
    }
    }