using TeslaShop.Service.DTOs.Payment;
using TeslaShop.Service.DTOs.Users;

namespace TeslaShop.Service.Interfaces;

public interface IPaymentService
{
    public Task<PaymentForResultDto> CreateAsync(PaymentForCreationDto dto);
    public Task<PaymentForResultDto> UpdateAsync(PaymentForUpdateDto dto);
    public Task<PaymentForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<PaymentForResultDto>> RetrieveAllAsync();
    public Task<bool> RemoveAsync(long id);
}
