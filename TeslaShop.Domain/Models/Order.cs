using TeslaShop.Domain.Commons;
using TeslaShop.Domain.Enums;

namespace TeslaShop.Domain.Models;

public class Order : Auditable
{
    public long CustomerId { get; set; }
    public User Customer { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }

    public OrderStatus OrderStatus { get; set; }
    public decimal TotalAmount
    {
        get
        {
            // Calculate the total amount by summing up the prices of all order items
            return OrderItems.Sum(item => item.Quantity * item.Product.Price);
        }
    }

}
