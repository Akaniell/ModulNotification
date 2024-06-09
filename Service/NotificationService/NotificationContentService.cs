using DTO.NotificationDTO;
using Repository.NotificationRepository;

namespace Service.NotificationService;

public class NotificationContentService(INotificationContentRepository notificationContentRepository) : INotificationContentService
{
    private INotificationContentRepository _notificationContentRepository = notificationContentRepository;
    
    public async Task<NotificationContentDTO> GetNotificationContent(long id) 
    {
        return await _notificationContentRepository.Get(id);
    }

    public async Task<List<NotificationContentDTO>> GetNotificationContents() 
    {
        return await _notificationContentRepository.GetAll(); 
    }
}