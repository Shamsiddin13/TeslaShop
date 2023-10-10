using TeslaShop.Domain.Commons;

namespace TeslaShop.Domain.Models;

public class Category : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
}
