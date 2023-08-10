namespace MakeYourTrip.Models
{
    public class BookingDetails
    {


        public string? Name { get; set; }
        public string Email { get; set; } = null!;
        public string? Address { get; set; }
        public string? PackageName { get; set; }
        public string? Hotelname { get; set; }
        public DateTime? DateOfTheTrip { get; set; }

        public DateTime? DateofBooking { get; set; }

        public int? NumberOfPeople { get; set; }

        public decimal? TotalAmount { get; set; }

    }
}
