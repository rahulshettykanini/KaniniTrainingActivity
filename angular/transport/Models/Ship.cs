using System;
using System.Collections.Generic;

namespace transport.Models;

public partial class Ship
{
    public string Sname { get; set; } = null!;

    public int? Capacity { get; set; }

    public string? Starting { get; set; }

    public string? Ending { get; set; }

    public int? Price { get; set; }
}
