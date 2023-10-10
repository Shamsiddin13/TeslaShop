using TeslaShop.Service.DTOs.OrderItem;

namespace TeslaShop.Service.Interfaces;

public interface IOrderItemService
{
    public Task<OrderItemForResultDto> CreateAsync(OrderItemForCreationDto dto);
    public Task<OrderItemForResultDto> UpdateAsync(OrderItemForUpdateDto dto);
    public Task<IEnumerable<OrderItemForResultDto>> RetrieveAllAsync();
    public Task<OrderItemForResultDto> RetrieveByIdAsync(long id);
    public Task<bool> RemoveAsync(long id);
}
