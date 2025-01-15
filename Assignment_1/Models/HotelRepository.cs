using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;

namespace Assignment_1.Models
{
    public class HotelRepository
    {
        public static List<Hotel> GetHotels()
        {
            return new List<Hotel>
        {
            new Hotel
            {
                Name = "CapeHoney",Id=1 ,
                
                MealTypes = new List<string> { "Regular", "Vegan", "Glutenfree" },
                RoomTypes = new List<RoomType>
                {
                    new RoomType { RoomName = "Standard", PricePerNight = 3000, Features = "Breakfast excluded, single bed, TV, internet" },
                   new RoomType { RoomName = "Deluxe", PricePerNight = 5000, Features = "Breakfast included, double (2) single beds, TV, internet" },
                   new RoomType{ RoomName = "Exquisite", PricePerNight= 7000, Features = "Breakfast included, queen-sized double beds, TV, internet, complimentary\r\ndrinks in refrigerator"},
                   new RoomType{RoomName = "Executive",PricePerNight = 10000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary\r\ndrinks in refrigerator; laundry, room service, tourism tour of Capetropolis"}

                }
            },
              new Hotel
            {
                Name = "CapeIvory", Id=2 ,
            
                MealTypes = new List<string> { "Regular", "Vegan","Halal","Kosher","Glutenfree", "keto" },
                RoomTypes = new List<RoomType>
                {
                   new RoomType { RoomName = "Standard", PricePerNight = 2500, Features = "Breakfast excluded, single bed, TV, internet" },
                   new RoomType { RoomName = "Deluxe", PricePerNight = 5000, Features = "Breakfast included, double (2) single beds, TV, internet" },
                   new RoomType{RoomName = "Executive",PricePerNight = 80000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary\r\ndrinks in refrigerator; laundry, room service, tourism tour of Capetropolis"}

                }
            },
             new Hotel
            {
                Name = "CapeSweet",Id=3 ,  
            
                MealTypes = new List<string> { "Regular", "Vegan","Halal","Kosher" },
                RoomTypes = new List<RoomType>
                {
                   new RoomType { RoomName = "Standard", PricePerNight = 3500, Features = "Breakfast excluded, single bed, TV, internet" },
                   new RoomType { RoomName = "Comfort", PricePerNight = 5000, Features = "Breakfast included, double (2) single beds, TV, internet" },
                   new RoomType{RoomName = "Executive",PricePerNight = 9000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary\r\ndrinks in refrigerator; laundry, room service, tourism tour of Capetropolis"},
                   new RoomType {RoomName = "Diamond",PricePerNight= 12000,Features=""}
                }
            },
             new Hotel
            {
                Name = "CapeHive",Id = 4 ,  
                MealTypes = new List<string> {  "Regular", "Vegan","Glutenfree", "keto","Paleo" },
                RoomTypes = new List<RoomType>
                {
                   new RoomType { RoomName = "Standard", PricePerNight = 5000, Features = "Breakfast excluded, single bed, TV, internet" },
                   new RoomType { RoomName = "Double", PricePerNight = 7000, Features = "Breakfast included, double (2) single beds, TV, internet" },
                   new RoomType{RoomName = "Executive",PricePerNight = 10000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary\r\ndrinks in refrigerator; laundry, room service, tourism tour of Capetropolis"}

                }
            },
              new Hotel
            {
                Name = "CapeCrow",Id=5 ,
                MealTypes = new List<string> { "Regular", "Vegan","Halal","Kosher","Indian"},
                RoomTypes = new List<RoomType>
                {
                   new RoomType { RoomName = "Budget", PricePerNight = 2500, Features = "Breakfast excluded, single bed, TV, internet" },
                   new RoomType { RoomName = "Spotlight", PricePerNight = 4000, Features = "Breakfast included, double (2) single beds, TV, internet" },
                   new RoomType{RoomName = "Deluxe",PricePerNight = 6000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary\r\ndrinks in refrigerator; laundry, room service, tourism tour of Capetropolis"},
                   new RoomType{RoomName = "Gold",PricePerNight = 8000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary\r\ndrinks in refrigerator; laundry, room service, tourism tour of Capetropolis"},
                   new RoomType{RoomName = "Diamond",PricePerNight = 12000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary\r\ndrinks in refrigerator; laundry, room service, tourism tour of Capetropolis"}
                }
            },
             // Add other hotels with meal types and room types
        };
        }
    }
}
            