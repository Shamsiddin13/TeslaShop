using TeslaShop.Domain.Enums;

namespace TeslaShop.Service.DTOs.Users;

public class UserForResultDto
{
    public long Id { get; set; }
    public string Username { get; set; }
    public string PhoneNumber { get; set; }
    public string ShippingAddress { get; set; }
    public UserRole Role { get; set; }
}
