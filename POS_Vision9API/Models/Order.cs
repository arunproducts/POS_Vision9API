using System;
using System.Collections.Generic;

namespace POS_Vision9API.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Shipping { get; set; }

    public string? CouponCode { get; set; }

    public string? Status { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
