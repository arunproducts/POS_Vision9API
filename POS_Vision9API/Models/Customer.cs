using System;
using System.Collections.Generic;

namespace POS_Vision9API.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Name { get; set; }

    public bool? IsWalkIn { get; set; }

    public int? LoyaltyPoints { get; set; }

    public int? BonusPoints { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
