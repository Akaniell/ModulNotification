using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;
using Repository.NotificationRepository;

namespace Service.NotificationService;

public class Notification_DataService(INotification_DataRepository notification_DataRepository) : INotification_DataService
{
    private INotification_DataRepository _notification_DataRepository = notification_DataRepository;
    
    public async Task<Notification_DataDTO> GetNotification_Data(long id) 
    {
        return await _notification_DataRepository.Get(id);
    }

    public async Task<List<Notification_DataDTO>> GetNotification_Datas() 
    {
        return await _notification_DataRepository.GetAll(); 
    }
    
    public async Task<IActionResult> InsertNotification_Data(CreateNotification_DataDTO dto)
    {
        return await _notification_DataRepository.Insert(dto);
    }

    public async Task<IActionResult> UpdateNotification_Data(UpdateNotification_DataDTO dto)
    {
        return await _notification_DataRepository.Update(dto);
    }

    public void DeleteNotification_Data(long id)
    {
        _notification_DataRepository.Delete(id);
    }
}