using System;
using System.Collections.Generic;

namespace MakeYourTrip.Models;

public partial class Hotel
{
    public int Hotelid { get; set; }

    public int? PackageId { get; set; }

    public string? Hotelname { get; set; }

    public decimal? HotelRating { get; set; }

    public decimal? HotelPrice { get; set; }

    public string? HotelsImage { get; set; }

    public virtual ICollection<BookingTrip> BookingTrips { get; set; } = new List<BookingTrip>();

    public virtual Package? Package { get; set; }
}
