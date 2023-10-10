using Microsoft.EntityFrameworkCore;
using TeslaShop.Data.IRepositories;
using TeslaShop.Service.Exceptions;
using TeslaShop.Service.Interfaces;
using TeslaShop.Service.DTOs.Users;
using TeslaShop.Data.Repositories;
using TeslaShop.Service.Mappings;
using TeslaShop.Domain.Models;
using AutoMapper;

namespace TeslaShop.Service.Services;

public class UserService : IUserService
{
    private readonly IMapper mapper = MappingProfile.Initialize();

    private readonly IRepository<User> userRepository = new Repository<User>();
    
    public async Task<UserForResultDto> CreateAsync(UserForCreationDto dto)
    {
        var user = (this.userRepository.SelectAllAsync()).FirstOrDefaultAsync(u => u.Email == u.Email);
        if (user is not null) 
            throw new CustomException(400, "User is already exist");
        
        var mappedUser = this.mapper.Map<User>(dto);
        
        var insertedUser = await this.userRepository.InsertAsync(mappedUser);
        
        var result = this.mapper.Map<UserForResultDto>(mappedUser);
        return result;
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var user = await this.userRepository.SelectByIdAsync(id);
        if (user is null)
            throw new CustomException(404, "User is not found");

        await this.userRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync()
    {
        var users = await this.userRepository.SelectAllAsync()
            .Include(u => u.Username)
            .ToListAsync();
     
        return this.mapper.Map<IEnumerable<UserForResultDto>>(users);  
    }

    public async Task<UserForResultDto> RetrieveByIdAsync(long id)
    {
        var user = await this.userRepository.SelectByIdAsync(id);
        if (user is null)
            throw new CustomException(404, "User is not found");

        return this.mapper.Map<UserForResultDto>(user);
    }

    public async Task<UserForResultDto> UpdateAsync(UserForUpdateDto dto)
    {
        var user = await this.userRepository.SelectByIdAsync(dto.Id);
        if (user is null)
            throw new CustomException(404, "User is not found");

        var mappedUser = this.mapper.Map<User>(dto); 
        mappedUser.UpdatedAt = DateTime.UtcNow;

        await this.userRepository.UpdateAsync(mappedUser);

        return this.mapper.Map<UserForResultDto>(mappedUser);
    }
}
