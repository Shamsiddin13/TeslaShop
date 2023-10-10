using TeslaShop.Service.DTOs.Orders;
using TeslaShop.Service.DTOs.Users;

namespace TeslaShop.Service.Interfaces;

public interface IOrderService
{
    public Task<OrderForResultDto> CreateAsync(OrderForCreationDto dto);
    public Task<OrderForResultDto> UpdateAsync(OrderForUpdateDto dto);
    public Task<OrderForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<OrderForResultDto>> RetrieveAllAsync();
    public Task<bool> RemoveAsync(long id);
}
