using TeslaShop.Domain.Commons;

namespace TeslaShop.Domain.Models;

public class Order : Auditable
{
    public long CustomerId { get; set; }
    public User Customer { get; set; }

    public string OrderStatus { get; set; }
    public decimal TotalAmount { get; set; }
}
