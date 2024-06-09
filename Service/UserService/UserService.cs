using Data.UserData;
using DTO.UserDTO;
using Microsoft.AspNetCore.Identity;
using Repository.UserRepository;

namespace Service.UserService;

public class UserService(IUserRepository userRepository) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;
    
    public async Task<UserDTO> GetUser(string id) 
    {
        return await _userRepository.Get(id);
    }

    public async Task<List<User>> GetUsers() 
    {
        return await _userRepository.GetAll(); 
    }

    public async Task<IdentityResult> InsertUser(CreateUserDTO dto)
    {
        return await _userRepository.Insert(dto); 
    }

    public async Task<IdentityResult> UpdateUser(UpdateUserDTO dto) 
    {
        return await _userRepository.Update(dto);
    }

    public void DeleteUser(string id) 
    {
        _userRepository.Delete(id);  
    }
}