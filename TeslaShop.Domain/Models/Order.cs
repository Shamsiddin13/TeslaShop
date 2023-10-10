using TeslaShop.Domain.Commons;
using TeslaShop.Domain.Enums;

namespace TeslaShop.Domain.Models;

public class Order : Auditable
{
    public long CustomerId { get; set; }
    public User Customer { get; set; }

    public OrderStatus OrderStatus { get; set; }
    public decimal TotalAmount { get; set; }
}
