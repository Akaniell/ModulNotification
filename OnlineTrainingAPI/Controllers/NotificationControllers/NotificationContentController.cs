using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;
using Service.NotificationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("notificationContents")]
public class NotificationContentController (INotificationContentService notificationContentService) : Controller
{
    [Route("{id}")] 
    [HttpGet] 
    public async Task<JsonResult> GetNotificationContent(long id) 
    {
        var notificationContent = await notificationContentService.GetNotificationContent(id);
        return Json(notificationContent);
    }
    
    [HttpGet] 
    public async Task<JsonResult> GetNotificationContents() 
    {
        var notificationContents = await notificationContentService.GetNotificationContents(); 
        return Json(notificationContents);
    }
}