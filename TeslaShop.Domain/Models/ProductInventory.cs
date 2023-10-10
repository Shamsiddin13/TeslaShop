using TeslaShop.Domain.Commons;

namespace TeslaShop.Domain.Models;

public class ProductInventory : Auditable
{
    public long ProductId { get; set; }
    public Product Product { get; set; }

    public long ProductQuantity { get; set; }
}
