using TeslaShop.Service.DTOs.Caregory;

namespace TeslaShop.Service.Interfaces;

public interface ICategoryService
{
    public Task<CategoryForResultDto> CreateAsync(CategoryForCreationDto dto);
    public Task<CategoryForResultDto> UpdateAsync(CategoryForUpdateDto dto);
    public Task<CategoryForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<CategoryForResultDto>> RetrieveAllAsync();
    public Task<bool> RemoveAsync(long id);
}
