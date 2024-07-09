using System.ComponentModel.DataAnnotations;
using CoreBusiness.Validations;

namespace CoreBusiness
{
    public class Booking
    {
        public int BookingId { get; set; }
        [Required]
        public string UserId { get; set; } = string.Empty;
        [Required]
        public int HotelId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        [Display(Name = "Check in")]
        public DateTime StartDate {  get; set; }
        [Required]
        [Display(Name = "Check out")]
        [BookingModel_EnsureValidEndDate]
        public DateTime EndDate { get; set; }
        [Required]
        [Display(Name = "Rooms")]
        [Range(0, int.MaxValue, ErrorMessage = "Invalid number of rooms.")]
        public int RoomQuantity { get; set; }
        [Required]
        [Display(Name = "Number of nights:")]
        [Range(0, int.MaxValue, ErrorMessage = "Invalid length of stay.")]
        public int BookingDayDuration { get; set; }
        [Required]
        [Display(Name = "Nightly rate:")]
        [Range(0, int.MaxValue, ErrorMessage = "Invalid hotel rate.")]
       /* [BookingModel_EnsureValidDailyRate]*/
        public int DailyRate {  get; set; }
        [Required]
        [Display(Name = "Total:")]
        [Range(0, int.MaxValue, ErrorMessage = "Invalid total.")]
        /*[BookingModel_EnsureValidTotalRate]*/
        public int RateTotal { get; set; }
        [Display(Name = "Special Requests")]
        [Range(0, 500, ErrorMessage = "Message too long.")]
        public string? SpecialRequests { get; set; } 

        public Hotel? Hotel { get; set; }
    }
}
