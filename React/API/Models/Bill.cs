namespace MakeYourTrip.Models
{
    public class Bill
    {

        public string? Name { get; set; }

        public string? Gender { get; set; }
        public string Email { get; set; } = null!;
        public string? Address { get; set; }
        public long? ContactNo { get; set; }
        public string? PackageName { get; set; }
        public string? Place { get; set; }
        public string? Duration { get; set; }
        public decimal? PackagePrice { get; set; }
        public string? Description { get; set; }
        public string? Hotelname { get; set; }
        public decimal? HotelRating { get; set; }
        public decimal? HotelPrice { get; set; }

        public DateTime? DateOfTheTrip { get; set; }

        public DateTime? DateofBooking { get; set; }

        public int? NumberOfPeople { get; set; }

        public decimal? TotalAmount { get; set; }

    

}
}
