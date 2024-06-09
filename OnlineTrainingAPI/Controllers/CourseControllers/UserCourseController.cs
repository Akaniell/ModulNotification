using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.AspNetCore.Mvc;
using Service.CourseService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("UserCourse")]

public class UserCourseController (IUserCourseService userCourseService) : Controller
{
    [HttpGet]
    
    public JsonResult GetUserCourses()
    {
        var UserCourses = userCourseService.GetUserCourses();
        return Json(UserCourses);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetUserCourse(long Id)
    {
        var userCourse = userCourseService.GetUserCourse(Id);
        return Json(userCourse);
    }
}