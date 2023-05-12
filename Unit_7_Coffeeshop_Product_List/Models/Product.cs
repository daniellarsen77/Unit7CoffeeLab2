using System;
using System.Collections.Generic;

namespace Unit_7_Coffeeshop_Product_List.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public double? Price { get; set; }

    public string? Category { get; set; }
}
