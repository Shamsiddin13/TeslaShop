using TeslaShop.Service.DTOs.Products;
using TeslaShop.Service.DTOs.Users;

namespace TeslaShop.Service.Interfaces;

public interface IProductService
{
    public Task<ProductForResultDto> CreateAsync(ProductForCreationDto dto);
    public Task<ProductForResultDto> UpdateAsync(ProductForUpdateDto dto);
    public Task<ProductForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<ProductForResultDto>> RetrieveAllAsync();
    public Task<bool> RemoveAsync(long id);
}
