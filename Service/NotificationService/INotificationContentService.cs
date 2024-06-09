using DTO.NotificationDTO;

namespace Service.NotificationService;

public interface INotificationContentService
{
    Task<NotificationContentDTO> GetNotificationContent(long id);
    Task<List<NotificationContentDTO>> GetNotificationContents();
}