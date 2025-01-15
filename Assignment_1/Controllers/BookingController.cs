using Assignment_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1.Controllers
{

public class BookingController : Controller
    {
        private readonly List<Hotel> hotels = HotelRepository.GetHotels();

        [HttpGet]
        public ActionResult Index()
        {
            return View(hotels);
        }

        [HttpGet]
        public ActionResult BookingForm(int id)
        {
            var selectedHotel = hotels.FirstOrDefault(h => h.Id == id);

            if (selectedHotel == null)
            {
                return HttpNotFound();
            }

            var viewModel = new BookingViewModel
            {
                Hotels = hotels,
                SelectedHotelId = id,
                MealTypes = selectedHotel.MealTypes,
                RoomTypes = selectedHotel.RoomTypes.Select(rt => rt.RoomName).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(BookingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var selectedHotel = hotels.FirstOrDefault(h => h.Id == viewModel.SelectedHotelId);
                var selectedRoom = selectedHotel?.RoomTypes.FirstOrDefault(r => r.RoomName == viewModel.RoomType);

                viewModel.Price = selectedRoom?.PricePerNight ?? 0;
                viewModel.Features = selectedRoom?.Features ?? "";

                // Save booking details to local storage (mocked as TempData here for simplicity)
                var bookingID = Guid.NewGuid();
                var timestamp = DateTime.Now;

                // Mocked saving booking logic
                TempData["BookingID"] = bookingID;

                return RedirectToAction("Confirmation");
            }

            viewModel.Hotels = hotels;
            return View("BookingForm", viewModel);
        }

        public ActionResult Confirmation()
        {
            ViewBag.BookingID = TempData["BookingID"];
            return View();
        }
    }
}



