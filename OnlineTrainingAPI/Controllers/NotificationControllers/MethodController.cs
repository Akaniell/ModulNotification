using DTO.NotificationDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.NotificationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("methods")]
public class MethodController (IMethodService methodService) : Controller
{
    [Route("{id}")] 
    [HttpGet] 
    public async Task<JsonResult> GetMethod(long id) 
    {
        var method = await methodService.GetMethod(id);
        return Json(method);
    }
    
    [HttpGet] 
    public async Task<JsonResult> GetMethods() 
    {
        var methods = await methodService.GetMethods(); 
        return Json(methods);
    }
    
    [Authorize]
    [Route("create")]
    [HttpPost]
    public async Task<IActionResult> CreateMethod(CreateMethodDTO dto)
    {
        var result = methodService.InsertMethod(dto);
        return await result;
    }
    
    [Authorize]
    [Route("update")]
    [HttpPost]
    public async Task<IActionResult> UpdateMethod(UpdateMethodDTO dto)
    {
        await methodService.UpdateMethod(dto);
        return Json("updated");
    }
    
    [Authorize]
    [Route("delete/{id}")]
    [HttpDelete]
    public JsonResult DeleteMethod(long id)
    {
        methodService.DeleteMethod(id);
        return Json("deleted");
    }
}