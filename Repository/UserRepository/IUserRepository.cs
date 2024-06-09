using Data.UserData;
using DTO.UserDTO;
using Microsoft.AspNetCore.Identity;

namespace Repository.UserRepository;

public interface IUserRepository
{
    Task<UserDTO> Get(string id);
    Task<List<User>> GetAll();
    Task<IdentityResult> Insert(CreateUserDTO dto);
    Task<IdentityResult> Update(UpdateUserDTO dto);
    void Delete(string id);
    void SaveChanges();
}