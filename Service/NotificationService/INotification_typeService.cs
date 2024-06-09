using DTO.NotificationDTO;

namespace Service.NotificationService;

public interface INotification_typeService
{
    Task<Notification_typeDTO> GetNotification_type(long id);
    Task<List<Notification_typeDTO>> GetNotification_types();
}