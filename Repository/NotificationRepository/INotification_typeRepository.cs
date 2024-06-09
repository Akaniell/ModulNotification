using DTO.NotificationDTO;

namespace Repository.NotificationRepository;

public interface INotification_typeRepository
{
    Task<Notification_typeDTO> Get(long id);
    Task<List<Notification_typeDTO>> GetAll();
}