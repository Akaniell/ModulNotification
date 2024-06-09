using Data.UserData;
using DTO.UserDTO;
using Microsoft.AspNetCore.Identity;

namespace Service.UserService;

public interface IUserService
{
    Task<UserDTO> GetUser(string id); 
    Task<List<User>> GetUsers(); 
    Task<IdentityResult> InsertUser(CreateUserDTO dto);  
    Task<IdentityResult> UpdateUser(UpdateUserDTO dto); 
    void DeleteUser(string id);
}