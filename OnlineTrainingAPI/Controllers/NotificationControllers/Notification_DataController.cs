using DTO.NotificationDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.NotificationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("notification_data's")]
public class Notification_DataController (INotification_DataService notification_DataService) : Controller
{
    [Route("{id}")] 
    [HttpGet] 
    public async Task<JsonResult> GetNotification_Data(long id) 
    {
        var notification_Data = await notification_DataService.GetNotification_Data(id);
        return Json(notification_Data);
    }
    
    [HttpGet] 
    public async Task<JsonResult> GetNotification_Datas() 
    {
        var notification_Datas = await notification_DataService.GetNotification_Datas(); 
        return Json(notification_Datas);
    }
    
    [Authorize]
    [Route("create")]
    [HttpPost]
    public async Task<IActionResult> CreateNotification_Data(CreateNotification_DataDTO dto)
    {
        var result = notification_DataService.InsertNotification_Data(dto);
        return await result;
    }
    
    [Authorize]
    [Route("update")]
    [HttpPost]
    public async Task<IActionResult> UpdateNotification_Data(UpdateNotification_DataDTO dto)
    {
        await notification_DataService.UpdateNotification_Data(dto);
        return Json("updated");
    }
    
    [Authorize]
    [Route("delete/{id}")]
    [HttpDelete]
    public JsonResult DeleteNotification_Data(long id)
    {
        notification_DataService.DeleteNotification_Data(id);
        return Json("deleted");
    }
}