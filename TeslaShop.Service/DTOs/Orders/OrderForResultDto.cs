using TeslaShop.Domain.Enums;
using TeslaShop.Domain.Models;
using TeslaShop.Service.DTOs.OrderItem;

namespace TeslaShop.Service.DTOs.Orders;

public class OrderForResultDto
{
    public long Id { get; set; }
    public long CustomerId { get; set; }
    public ICollection<OrderItemForResultDto> OrderItems { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public decimal TotalAmount { get; set; }

}
