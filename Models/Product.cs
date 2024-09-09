using System;
using System.Collections.Generic;

namespace sampleapi.Models;

public partial class Product
{
    public int Productid { get; set; }

    public string? Productname { get; set; }

    public string? Category { get; set; }
}
