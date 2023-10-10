using TeslaShop.Domain.Enums;
using TeslaShop.Domain.Models;

namespace TeslaShop.Service.DTOs.Orders;

public class OrderForCreationDto
{
    public long CustomerId { get; set; }
    public long ProductId { get; set; }
    public OrderStatus OrderStatus { get; set; }
}
