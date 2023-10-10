using TeslaShop.Service.DTOs.Users;

namespace TeslaShop.Service.Interfaces;

public interface IUserService
{
    public Task<UserForResultDto> CreateAsync(UserForCreationDto dto);
    public Task<UserForResultDto> UpdateAsync(UserForUpdateDto dto);
    public Task<UserForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<UserForResultDto>> RetrieveAllAsync();
    public Task<bool> RemoveAsync(long id);
}
