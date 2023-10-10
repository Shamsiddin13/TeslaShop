using TeslaShop.Domain.Enums;
using TeslaShop.Domain.Models;

namespace TeslaShop.Service.DTOs.Payment;

public class PaymentForResultDto
{
    public long Id { get; set; }    
    public long OrderId { get; set; }
    public PaymentType PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
}
