using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;

namespace Repository.NotificationRepository;

public interface INotification_DataRepository
{
    Task<Notification_DataDTO> Get(long id);
    Task<List<Notification_DataDTO>> GetAll();
    Task<IActionResult> Insert(CreateNotification_DataDTO dto);
    Task<IActionResult> Update(UpdateNotification_DataDTO dto);
    void Delete(long id);
    void SaveChanges();
}