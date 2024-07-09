using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class HotelSearch
    {
        [Display(Name = "Destination")]
        public string SearchTerm { get; set; } = string.Empty;
        [Display(Name = "Check in")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "Check out")]
        public DateTime? EndDate { get; set; }
        [Display(Name = "Rooms")]
        public int? RoomQuantity { get; set; }
        [Display(Name = "Min price per night")]
        public int? MinPrice { get; set; }
        [Display(Name = "Max price per night")]
        public int? MaxPrice { get; set; }
        [Display(Name = "Adults")]
        public int? AdultQuantity { get; set; }
        [Display(Name = "Children")]
        public int? ChildQuantity {  get; set; }
    }
}
