using DTO.NotificationDTO;
using Repository.NotificationRepository;

namespace Service.NotificationService;

public class Notification_typeService(INotification_typeRepository notification_typeRepository) : INotification_typeService
{
    private INotification_typeRepository _notification_typeRepository = notification_typeRepository;
    
    public async Task<Notification_typeDTO> GetNotification_type(long id) 
    {
        return await _notification_typeRepository.Get(id);
    }

    public async Task<List<Notification_typeDTO>> GetNotification_types() 
    {
        return await _notification_typeRepository.GetAll(); 
    }
}