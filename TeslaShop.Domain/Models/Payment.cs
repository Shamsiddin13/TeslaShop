using TeslaShop.Domain.Commons;
using TeslaShop.Domain.Enums;

namespace TeslaShop.Domain.Models;

public class Payment : Auditable
{
    public long OrderId { get; set; }
    public Order Order { get; set; }    

    public PaymentType PaymentMethod { get; set; }
    public string TransactionsDetails { get; set; }
    public string PaymentStatus { get; set; }
}
