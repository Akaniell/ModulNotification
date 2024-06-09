using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;

namespace Service.NotificationService;

public interface INotification_DataService
{
    Task<Notification_DataDTO> GetNotification_Data(long id);
    Task<List<Notification_DataDTO>> GetNotification_Datas();
    Task<IActionResult> InsertNotification_Data(CreateNotification_DataDTO dto);
    Task<IActionResult> UpdateNotification_Data(UpdateNotification_DataDTO dto);
    void DeleteNotification_Data(long id);
}