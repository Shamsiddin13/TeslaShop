using TeslaShop.Domain.Commons;

namespace TeslaShop.Domain.Models;

public class OrderItem : Auditable
{
    public long OrderId { get; set; }
    public Order Order { get; set; }

    public long ProductId { get; set; }
    public Product Product { get; set; }
    
    public long Quantity { get; set; }

}
