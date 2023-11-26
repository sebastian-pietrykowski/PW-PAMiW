using System;
using System.Collections.Generic;

namespace P08ShopWebApp.Client.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime ReleaseDate { get; set; }
}
