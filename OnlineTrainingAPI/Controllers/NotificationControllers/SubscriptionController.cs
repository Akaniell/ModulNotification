using DTO.NotificationDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.NotificationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("subscriptions")]
public class SubscriptionController (ISubscriptionService subscriptionService) : Controller
{
    [Route("{id}")] 
    [HttpGet] 
    public async Task<JsonResult> GetSubscription(long id) 
    {
        var subscription = await subscriptionService.GetSubscription(id);
        return Json(subscription);
    }
    
    [HttpGet] 
    public async Task<JsonResult> GetSubscriptions() 
    {
        var subscriptions = await subscriptionService.GetSubscriptions(); 
        return Json(subscriptions);
    }
    
    [Authorize]
    [Route("create")]
    [HttpPost]
    public async Task<IActionResult> CreateSubscription(CreateSubscriptionDTO dto)
    {
        var result = subscriptionService.InsertSubscription(dto);
        return await result;
    }
    
    [Authorize]
    [Route("update")]
    [HttpPost]
    public async Task<IActionResult> UpdateSubscription(UpdateSubscriptionDTO dto)
    {
        await subscriptionService.UpdateSubscription(dto);
        return Json("updated");
    }
    
    [Authorize]
    [Route("delete/{id}")]
    [HttpDelete]
    public JsonResult DeleteSubscription(long id)
    {
        subscriptionService.DeleteSubscription(id);
        return Json("deleted");
    }
}