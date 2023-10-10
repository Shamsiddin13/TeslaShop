namespace TeslaShop.Service.DTOs.Products;

public class ProductForCreationDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public long AvailableQuantity { get; set; }
    public double ProductRating { get; set; }

    public long CategoryId { get; set; }
}
