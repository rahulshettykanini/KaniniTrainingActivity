using System;
using System.Collections.Generic;

namespace transport.Models;

public partial class Customer
{
    public string Cname { get; set; } = null!;

    public string? Product { get; set; }

    public int? Weight { get; set; }

    public string? Source { get; set; }

    public string? Destination { get; set; }

    public string? Ship { get; set; }
}
