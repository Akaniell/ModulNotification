using DTO.NotificationDTO;

namespace Repository.NotificationRepository;

public interface INotificationContentRepository
{
    Task<NotificationContentDTO> Get(long id);
    Task<List<NotificationContentDTO>> GetAll();
}