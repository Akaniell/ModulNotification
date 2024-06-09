using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.AspNetCore.Mvc;
using Service.CourseService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("theory")]

public class TheoryController (ITheoryService theoryService) : Controller
{
    [HttpGet]
    
    public JsonResult GetTheories() 
    {
        var theories = theoryService.GetTheories(); 
        return Json(theories);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetTheory(long id)
    {
        var theory = theoryService.GetTheory(id);
        return Json(theory);
    }
    
    [Route("create")] 
    [HttpPost]
    
    public JsonResult InsertTheory(CreateTheoryDTO dto) 
    {
        theoryService.InsertTheory(dto); 

        return Json("Theory inserted");
    }

    [Route("update")]
    [HttpPatch]
    public JsonResult UpdateTheory(UpdateTheoryDTO dto)
    {
        theoryService.UpdateTheory(dto);

        return Json("updated");

    }
    
    [Route("delete/{id}")]
    [HttpDelete]
    
    public JsonResult DeleteTheory(long id) 
    {
        theoryService.DeleteTheory(id); 

        return Json("deleted"); 
    }
}