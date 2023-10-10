using TeslaShop.Domain.Enums;
using TeslaShop.Domain.Models;

namespace TeslaShop.Service.DTOs.Orders;

public class OrderForUpdateDto
{
    public long Id { get; set; }
    public long CustomerId { get; set; }
    public long ProductId { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public decimal TotalAmount { get; set; }
}
