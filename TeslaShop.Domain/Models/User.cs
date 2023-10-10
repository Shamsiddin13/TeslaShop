using TeslaShop.Domain.Commons;
using TeslaShop.Domain.Enums;

namespace TeslaShop.Domain.Models;

public class User : Auditable
{
    public string Username { get; set; }  
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string ShippingAddress { get; set; }
    public UserRole Role { get; set; }
    public Gender Gender { get; set; }
}
