using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.AspNetCore.Mvc;
using Service.CourseService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("practice")]

public class PracticeController (IPracticeService practiceService) : Controller
{
    [HttpGet]
    
    public JsonResult GetPractices() 
    {
        var Practices = practiceService.GetPractices(); 
        return Json(Practices);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetPractice(long id)
    {
        var practice = practiceService.GetPractice(id);
        return Json(practice);
    }
    
    [Route("create")] 
    [HttpPost]
    
    public JsonResult InsertPractice(CreatePracticeDTO dto) 
    {
        practiceService.InsertPractice(dto); 

        return Json("Practice inserted");
    }

    [Route("update")]
    [HttpPatch]
    public JsonResult UpdatePractice(UpdatePracticeDTO dto)
    {
        practiceService.UpdatePractice(dto);

        return Json("updated");

    }
    
    [Route("delete/{id}")]
    [HttpDelete]
    
    public JsonResult DeletePractice(long id) 
    {
        practiceService.DeletePractice(id); 

        return Json("deleted"); 
    }
}