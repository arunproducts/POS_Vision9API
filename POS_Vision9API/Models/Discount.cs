using System;
using System.Collections.Generic;

namespace POS_Vision9API.Models;

public partial class Discount
{
    public int DiscountId { get; set; }

    public string? Description { get; set; }

    public decimal Percentage { get; set; }

    public decimal? MinPurchaseAmount { get; set; }

    public bool? IsActive { get; set; }
}
