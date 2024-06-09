using Microsoft.AspNetCore.Mvc;
using Service.NotificationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("notification_types")]
public class Notification_typeController (INotification_typeService notification_typeService) : Controller
{
    [Route("{id}")] 
    [HttpGet] 
    public async Task<JsonResult> GetNotification_type(long id) 
    {
        var notification_type = await notification_typeService.GetNotification_type(id);
        return Json(notification_type);
    }
    
    [HttpGet] 
    public async Task<JsonResult> GetNotification_types() 
    {
        var notification_types = await notification_typeService.GetNotification_types(); 
        return Json(notification_types);
    }
}