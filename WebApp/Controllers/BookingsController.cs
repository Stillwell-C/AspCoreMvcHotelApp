using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UseCases.Interfaces;
using WebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using CoreBusiness;

namespace WebApp.Controllers
{
    [Authorize]
    public class BookingsController: Controller
    {
        private readonly IAddBookingUseCase addBookingUseCase;
        private readonly IViewHotelByIdUseCase viewHotelByIdUseCase;
        private readonly IViewBookingsByUserIdUseCase viewBookingsByUserIdUseCase;
        private readonly IViewBookingByIdUseCase viewBookingByIdUseCase;
        private readonly IEditBookingUseCase editBookingUseCase;
        private readonly IDeleteBookingUseCase deleteBookingUseCase;
        private readonly UserManager<IdentityUser> userManager;

        public BookingsController(IAddBookingUseCase addBookingUseCase, IViewHotelByIdUseCase viewHotelByIdUseCase, IViewBookingsByUserIdUseCase viewBookingsByUserIdUseCase, IViewBookingByIdUseCase viewBookingByIdUseCase, IEditBookingUseCase editBookingUseCase, IDeleteBookingUseCase deleteBookingUseCase, UserManager<IdentityUser> userManager)
        {
            this.addBookingUseCase = addBookingUseCase;
            this.viewHotelByIdUseCase = viewHotelByIdUseCase;
            this.viewBookingsByUserIdUseCase = viewBookingsByUserIdUseCase;
            this.viewBookingByIdUseCase = viewBookingByIdUseCase;
            this.editBookingUseCase = editBookingUseCase;
            this.deleteBookingUseCase = deleteBookingUseCase;
            this.userManager = userManager;
        }
        public IActionResult Add(int id)
        {
            ViewBag.action = "add";
            var userId = userManager.GetUserId(User);
            var newBooking = new Booking
            {
                UserId = userId,
            };
            var hotel = viewHotelByIdUseCase.Execute(id);
            var bookingViewModel = new BookingViewModel
            {
                Hotel = hotel,
                Booking = newBooking
            };
            ViewBag.PageTitle = $"Book a Stay at {hotel.Hotel_name}";
            return View(bookingViewModel);
        }

        [HttpPost]
        public IActionResult Add(BookingViewModel bookingViewModel)
        {
            if (ModelState.IsValid)
            {
                var newBooking = addBookingUseCase.Execute(bookingViewModel.Booking);
                bookingViewModel.Booking = newBooking;
                ViewBag.Type = "create";
                return View("Success", bookingViewModel);
            }
            ViewBag.action = "add";
            var hotel = viewHotelByIdUseCase.Execute(bookingViewModel.Booking.HotelId);
            bookingViewModel.Hotel = hotel;

            ViewBag.PageTitle = $"Book a Stay at {hotel.Hotel_name}";
            return View(bookingViewModel);
        }

        public IActionResult ViewBookings(string id)
        {
            var userId = userManager.GetUserId(User);
            var active = id == "All" ? false : true;
            var bookings = viewBookingsByUserIdUseCase.Execute(userId, active);
            ViewBag.TimeFrame = id == "All" ? "All" : "Current";
            ViewBag.PageTitle = "View Bookings";
            ViewBag.DeleteBookingConfirmation = TempData["DeleteBookingConfirmation"] ?? false;
            ViewBag.DeleteError = TempData["DeleteError"] ?? false;
            return View(bookings);
        }

        public IActionResult Edit(int id)
        {
            var userId = userManager.GetUserId(User);
            var booking = viewBookingByIdUseCase.Execute(id);
            var bookingViewModel = new BookingViewModel();
            if (booking != null && booking.UserId == userId)
            {
                bookingViewModel.Booking = booking;
                bookingViewModel.Hotel = booking.Hotel;
            } else
            {
                bookingViewModel = null;
            }

            ViewBag.Action = "edit";
            ViewBag.PageTitle = "Edit Booking";

            return View(bookingViewModel);
        }

        [HttpPost]
        public IActionResult Edit(BookingViewModel bookingViewModel) {
            var userId = userManager.GetUserId(User);

            if (ModelState.IsValid && userId == bookingViewModel.Booking.UserId)
            {
                editBookingUseCase.Execute(bookingViewModel.Booking.BookingId, bookingViewModel.Booking);
                ViewBag.Type = "edit";

                return View("Success", bookingViewModel);
            }

            
            bookingViewModel.Hotel = bookingViewModel.Booking.Hotel;

            ViewBag.action = "edit";
            ViewBag.PageTitle = "Edit Booking";
            return View(bookingViewModel);
        }

        public IActionResult Delete(int id)
        {
            var userId = userManager.GetUserId(User);
            var booking = viewBookingByIdUseCase.Execute(id);
            if (booking != null && booking.UserId == userId)
            {
                deleteBookingUseCase.Execute(id);
                TempData["DeleteBookingConfirmation"] = true;
                return RedirectToAction("ViewBookings");
            }

            TempData["DeleteError"] = true;
            return RedirectToAction("ViewBookings");

        }

    }
}
