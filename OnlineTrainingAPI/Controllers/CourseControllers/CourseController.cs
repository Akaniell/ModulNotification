using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.AspNetCore.Mvc;
using Service.CourseService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("course")]

public class CourseController (ICourseService courseService) : Controller
{
    [HttpGet]
    
    public JsonResult GetCourses() 
    {
        var courses = courseService.GetCourses(); 
        return Json(courses);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetCourse(long id)
    {
        var course = courseService.GetCourse(id);
        return Json(course);
    }
    
    [Route("create")] 
    [HttpPost]
    
    public JsonResult InsertCourse(CreateCourseDTO dto) 
    {
        courseService.InsertCourse(dto); 

        return Json("Course inserted");
    }

    [Route("update")]
    [HttpPatch]
    public JsonResult UpdateCourse(UpdateCourseDTO dto)
    {
        courseService.UpdateCourse(dto);

        return Json("updated");

    }
    
    [Route("delete/{id}")]
    [HttpDelete]
    
    public JsonResult DeleteCourse(long id) 
    {
        courseService.DeleteCourse(id); 

        return Json("deleted"); 
    }
}