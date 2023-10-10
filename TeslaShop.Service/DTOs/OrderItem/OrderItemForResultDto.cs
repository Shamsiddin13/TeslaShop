namespace TeslaShop.Service.DTOs.OrderItem;

public class OrderItemForResultDto
{
    public long Id { get; set; }
    public long OrderId { get; set; }
    public long ProductId { get; set; }
    public long Quantity { get; set; }
}
