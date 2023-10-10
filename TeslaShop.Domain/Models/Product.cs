using TeslaShop.Domain.Commons;

namespace TeslaShop.Domain.Models;

public class Product : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }   
    public double ProductRating { get; set; }
    
    public long CategoryId { get; set; } 
    public Category ProductCategory { get; set; }
}
