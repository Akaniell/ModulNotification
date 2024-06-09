using Data.GradeData;
using DTO.GradeDTO;
using Microsoft.AspNetCore.Mvc;
using Service.GradeService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("testAnswer")]

public class TestAnswerController (ITestAnswerService testAnswerService) : Controller
{
    [HttpGet]
    
    public JsonResult GetTestAnswers() 
    {
        var testAnswers = testAnswerService.GetTestAnswers(); 
        return Json(testAnswers);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetTestAnswer(long id)
    {
        var testAnswer = testAnswerService.GetTestAnswer(id);
        return Json(testAnswer);
    }
    
    [Route("create")] 
    [HttpPost]
    
    public JsonResult InsertTestAnswer(CreateTestAnswerDTO dto) 
    { 
        testAnswerService.InsertTestAnswer(dto); 

        return Json("TestAnswer inserted");
    }

    [Route("update")]
    [HttpPatch]
    public JsonResult UpdateTestAnswer(UpdateTestAnswerDTO dto) 
    {
        testAnswerService.UpdateTestAnswer(dto);

        return Json("updated");

    }
    
    [Route("delete/{id}")]
    [HttpDelete]
    
    public JsonResult DeleteTestAnswer(long id) 
    {
        testAnswerService.DeleteTestAnswer(id); 

        return Json("deleted"); 
    }
}