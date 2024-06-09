using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;
using Service.NotificationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("method_types")]
public class Method_typeController (IMethod_typeService method_typeService) : Controller
{
    [Route("{id}")] 
    [HttpGet] 
    public async Task<JsonResult> GetMethod_type(long id) 
    {
        var method_type = await method_typeService.GetMethod_type(id);
        return Json(method_type);
    }
    [HttpGet] 
    public async Task<JsonResult> GetMethod_types() 
    {
        var method_types = await method_typeService.GetMethod_types(); 
        return Json(method_types);
    }
}