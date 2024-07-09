using System.ComponentModel.DataAnnotations;


namespace CoreBusiness
{
    public class Hotel
    {
        [Key]
        public int Hotel_id { get; set; }
        public int Chain_id { get; set; }
        public string Chain_name { get; set; } = string.Empty;
        public int Brand_id { get; set; }
        public string Brand_name { get; set;} = string.Empty;
        public string Hotel_name {  get; set; } = string.Empty;
        public string Hotel_formerly_name {  get; set; } = string.Empty;
        public string Hotel_translated_name { get; set; } = string.Empty;
        public string Addressline1 {  get; set; } = string.Empty;
        public string Addressline2 { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Countryisocode { get; set; } = string.Empty;
        public double Star_rating { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Url {  get; set; } = string.Empty;
        public string Checkin { get; set; } = string.Empty;
        public string Checkout { get; set; } = string.Empty;
        public int? Numberrooms { get; set; }
        public int? Numberfloors { get; set;}
        public int? Yearopened { get; set; }
        public int? Yearrenovated { get; set; }
        public string Photo1 { get; set; } = string.Empty;
        public string Photo2 { get; set; } = string.Empty;
        public string Photo3 { get; set; } = string.Empty;
        public string Photo4 { get; set; } = string.Empty;
        public string Photo5 { get; set; } = string.Empty;
        public string Overview { get; set; } = string.Empty;
        public int Rates_from {  get; set; }
        public int Continent_id { get; set; }
        public string Continent_name { get; set; } = string.Empty;
        public int City_id { get; set; }
        public int Country_id { get; set; }
        public int Number_of_reviews { get; set; }
        public double Rating_average {  get; set; }
        public string Rates_currency { get; set; } = string.Empty;
        public string Timezone {  get; set; } = string.Empty;

        public List<Booking>? Bookings { get; set; }

    }
}
