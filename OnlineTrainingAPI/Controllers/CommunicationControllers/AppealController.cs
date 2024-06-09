using Data.CommunicationData;
using DTO.CommunicationDTO;
using Microsoft.AspNetCore.Mvc;
using Service.CommunicationService;


namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("appeal")]

public class AppealController(IAppealService appealService) : Controller
{
    [HttpGet]

    public JsonResult GetAppeals()
    {
        var Appeals = appealService.GetAppeals();
        return Json(Appeals);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetAppeal(long id)
    {
        var appeal = appealService.GetAppeal(id);
        return Json(appeal);
    }

    [Route("create")]
    [HttpPost]

    public JsonResult InsertAppeal(CreateAppealDTO dto)
    {
        appealService.InsertAppeal(dto);

        return Json("Appeal inserted");
    }

    [Route("update")]
    [HttpPatch]
    public JsonResult UpdateAppeal(UpdateAppealDTO dto)
    {
        appealService.UpdateAppeal(dto);

        return Json("updated");
    }

    [Route("delete/{id}")]
    [HttpDelete]

    public JsonResult DeleteAppeal(long id)
    {
        appealService.DeleteAppeal(id);

        return Json("deleted");
    }
}