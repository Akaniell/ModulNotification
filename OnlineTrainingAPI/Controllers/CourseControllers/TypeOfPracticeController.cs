using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.AspNetCore.Mvc;
using Service.CourseService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("TypeOfPractice")]

public class TypeOfPracticeController (ITypeOfPracticeService typeOfPracticeService) : Controller
{
    [HttpGet]

    public JsonResult GetTypeOfPractices()
    {
        var typeOfPractices = typeOfPracticeService.GetTypeOfPractices();
        return Json(typeOfPractices);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetTypeOfPractice(long Id)
    {
        var typeOfPractrice = typeOfPracticeService.GetTypeOfPractice(Id);
        return Json(typeOfPractrice);
    }
}