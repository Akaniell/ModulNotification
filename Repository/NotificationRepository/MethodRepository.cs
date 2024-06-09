using Data.NotificationData;
using Data.NotificationData;
using Data.UserData;
using DTO.NotificationDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Repository.NotificationRepository;

public class MethodRepository(UserManager<User> userManager, ApplicationContext context) : IMethodRepository
{
    private ApplicationContext _context = context;
    private DbSet<Method> _methods = context.Set<Method>();
    private DbSet<Method_type> _methodTypes = context.Set<Method_type>();
    
    public async Task<MethodDTO> Get(long id)
    {
        var method = _methods
            .Include(e=>e.User)
            .Include(e=>e.Method_type)
            .SingleOrDefault(e => e.Id == id);
        if (method == null) return await Task.FromResult<MethodDTO>(null);

        return await Task.FromResult(new MethodDTO
        {
            Id = method.Id,
            UserName = method.User.UserName,
            Method_typeName = method.Method_type.Name,
            Sending_Data = method.Sending_Data
        });
    }
    
    public async Task<List<MethodDTO>> GetAll()
    {
        var methods = _methods
            .Include(e=>e.User)
            .Include(e=>e.Method_type)
            .ToList();

        return await Task.FromResult(methods.Select(method => new MethodDTO()
            {
                Id = method.Id,
                UserName = method.User.UserName,
                Method_typeName = method.Method_type.Name,
                Sending_Data = method.Sending_Data
            }).ToList());
    }

    public async Task<IActionResult> Insert(CreateMethodDTO dto)
    {
        var user = await userManager.FindByNameAsync(dto.UserName);
        var methodType = _methodTypes.SingleOrDefault(e => e.Name == dto.Method_typeName);
        if (user == null) return new BadRequestObjectResult("Пользователь не найден");
        if (methodType == null) return new BadRequestObjectResult("Метод получения не найден");
        var method = new Method
        {
            //Id = dto.Id,
            UserId = user.Id,
            Method_type_id = methodType.Id,
            Sending_Data = dto.Sending_Data
        };
        _methods.Add(method);
        await _context.SaveChangesAsync();
        return new OkResult();
    }

    public async Task<IActionResult> Update(UpdateMethodDTO dto)
    {
        var user = await userManager.FindByNameAsync(dto.UserName);
        var methodType = _methodTypes.SingleOrDefault(e => e.Name == dto.Method_typeName);
        var method = _methods.SingleOrDefault(e => e.Id == dto.Id);
        if (user == null) return new BadRequestObjectResult("Пользователь не найден");
        if (methodType == null) return new BadRequestObjectResult("Метод получения не найден");
        if (method == null) return new BadRequestObjectResult("Данный способ получения не найден");
        method.UserId = user.Id;
        method.Method_type_id = methodType.Id;
        method.Sending_Data = dto.Sending_Data;
        _methods.Update(method);
        await _context.SaveChangesAsync();
        return new OkResult();
    }
    
    public void Delete(long id)
    {
        var method = _methods.SingleOrDefault(e => e.Id == id);
        if (method == null) return;
        _methods.Remove(method);
        _context.SaveChanges();
    }
    
    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}