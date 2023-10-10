using TeslaShop.Domain.Models;

namespace TeslaShop.Service.DTOs.OrderItem;

public class OrderItemForCreationDto
{
    public long OrderId { get; set; }
    public long ProductId { get; set; }
    public long Quantity { get; set; }
}
