using Data.NotificationData;
using DTO.NotificationDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.NotificationRepository;

public class Notification_typeRepository(ApplicationContext context) : INotification_typeRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Notification_type> _notification_types = context.Set<Notification_type>();

    public async Task<Notification_typeDTO> Get(long id)
    {
        var notification_type = _notification_types.SingleOrDefault(e => e.Id == id);
        if (notification_type == null) return await Task.FromResult<Notification_typeDTO>(null);

        return await Task.FromResult(new Notification_typeDTO
        {
            Id = notification_type.Id,
            Name = notification_type.Name,
            Mandatory = notification_type.Mandatory
        });
    }

    public async Task<List<Notification_typeDTO>> GetAll()
    {
        var notification_types = _notification_types.ToList();

        return await Task.FromResult(notification_types.Select(notification_type => new Notification_typeDTO
        {
            Id = notification_type.Id,
            Name = notification_type.Name,
            Mandatory = notification_type.Mandatory
        }).ToList());
    }
}