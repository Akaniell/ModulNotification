using Data.NotificationData;
using DTO.NotificationDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.NotificationRepository;

public class Method_typeRepository(ApplicationContext context) : IMethod_typeRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Method_type> _method_types = context.Set<Method_type>();
    
    public async Task<Method_typeDTO> Get(long id)
    {
        var method_type = _method_types.SingleOrDefault(e => e.Id == id);
        if (method_type == null) return await Task.FromResult<Method_typeDTO>(null);

        return await Task.FromResult(new Method_typeDTO
        {
            Id = method_type.Id,
            Name = method_type.Name
        });
    }

    public async Task<List<Method_typeDTO>> GetAll()
    {
        var method_types = _method_types.ToList();

        return await Task.FromResult(method_types.Select(method_type => new Method_typeDTO
            {
                Id = method_type.Id,
                Name = method_type.Name
            })
            .ToList());
    }
}