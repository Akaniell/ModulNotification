using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;
using Service.NotificationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("patterns")]
public class PatternController (IPatternService patternService) : Controller
{
    [Route("{id}")] 
    [HttpGet] 
    public async Task<JsonResult> GetPattern(long id) 
    {
        var pattern = await patternService.GetPattern(id);
        return Json(pattern);
    }
    
    [HttpGet] 
    public async Task<JsonResult> GetPatterns() 
    {
        var patterns = await patternService.GetPatterns(); 
        return Json(patterns);
    }
}