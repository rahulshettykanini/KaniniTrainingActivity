using System;
using System.Collections.Generic;

namespace MakeYourTrip.Models;

public partial class BookingTrip
{
    public int BookingTripid { get; set; }

    public int? UserId { get; set; }

    public DateTime? DateOfTheTrip { get; set; }

    public DateTime? DateofBooking { get; set; }

    public int? NumberOfPeople { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? PackageId { get; set; }

    public int? Hotelid { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual Package? Package { get; set; }

    public virtual User? User { get; set; }
}
