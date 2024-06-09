using Data.NotificationData;
using DTO.NotificationDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.NotificationRepository;

public class NotificationContentRepository(ApplicationContext context) : INotificationContentRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<NotificationContent> _notificationContents = context.Set<NotificationContent>();
    
    public async Task<NotificationContentDTO> Get(long id)
    {
        var notificationContent = _notificationContents.SingleOrDefault(e => e.Id == id);
        if (notificationContent == null) return await Task.FromResult<NotificationContentDTO>(null);

        return await Task.FromResult(new NotificationContentDTO
        {
            Id = notificationContent.Id,
            PatternId = notificationContent.PatternId,
            TypeId = notificationContent.TypeId
        });
    }

    public async Task<List<NotificationContentDTO>> GetAll()
    {
        var notificationContents = _notificationContents.ToList();

        return await Task.FromResult(notificationContents.Select(notificationContent => new NotificationContentDTO
            {
                Id = notificationContent.Id,
                PatternId = notificationContent.PatternId,
                TypeId = notificationContent.TypeId
            })
            .ToList());
    }
}