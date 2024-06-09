using Data.UserData;
using DTO.UserDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Repository.UserRepository;

public class UserRepository(UserManager<User> userManager, ApplicationContext context) : IUserRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<User> _users = context.Set<User>();

    public async Task<UserDTO> Get(string id)
    {
        var user = await userManager.FindByIdAsync(id);
        if (user == null) return null;
        return new UserDTO
        {
            UserId = user.Id,
            First_name = user.First_name,
            Last_name = user.Last_name,
            Login = user.UserName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber
        };
        /*var user = _users.SingleOrDefault(e => e.Id == id);
        if (user == null) return null;

        var userDTO = new UserDTO
        {
            Id = user.Id,
            first_name = user.first_name,
            last_name = user.last_name,
            login = user.login,
            password = user.password,
            email = user.email,
            created_at = user.created_at
        };
        return userDTO;*/
    }

    public async Task<List<User>> GetAll()
    {
        return await userManager.Users.ToListAsync();
        /*var users = _users.ToList();
        return users.Select(user => new UserDTO
            {
                Id = user.Id,
                first_name = user.first_name,
                last_name = user.last_name,
                login = user.login,
                password = user.password,
                email = user.email,
                created_at = user.created_at
            }).ToList();*/
    }

    public async Task<IdentityResult> Insert(CreateUserDTO dto)
    {
        User user = new User
        {
            First_name = dto.First_name,
            Last_name = dto.Last_name,
            UserName = dto.Login,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber
        };
        var result = await userManager.CreateAsync(user, dto.Password);
        return result;
        /*var actualTime = DateTime.Now;
        var user = new User
        {
            first_name = dto.first_name,
            last_name = dto.last_name,
            login = dto.login,
            password = dto.password,
            email = dto.email,
            created_at = actualTime.ToString("yyyy-MM-dd HH:mm:ss.fff")
        };
        _users.Add(user);
        context.SaveChanges();*/
    }

    public async Task<IdentityResult> Update(UpdateUserDTO dto)
    {
        var user = _users.SingleOrDefault(u => u.Id == dto.UserId);
        if (user == null) return IdentityResult.Failed();
        user.First_name = dto.First_name;
        user.Last_name = dto.Last_name;
        user.UserName = dto.Login;
        user.Email = dto.Email;
        user.PhoneNumber = dto.PhoneNumber;
        if (!string.IsNullOrWhiteSpace(dto.Password))
        {
            var passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, dto.Password);
        }
        _users.Update(user);
        await context.SaveChangesAsync();
        return IdentityResult.Success;
        /*var user = _users.SingleOrDefault(e => e.Id == dto.Id);
        if (user == null) return;

        user.first_name = dto.first_name;
        user.last_name = dto.last_name;
        user.login = dto.login;
        user.password = dto.password;
        user.email = dto.email;

        _users.Update(user);
        context.SaveChanges();*/
    }

    public void Delete(string id)
    {
        var user =_users.SingleOrDefault(u => u.Id == id);
        if (user == null) return;

        _users.Remove(user);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}