using DTO.CommunicationDTO;
using Data.CommunicationData;
using Microsoft.AspNetCore.Mvc;
using Service.CommunicationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("personal")]

public class PersonalController(IPersonalService personalService) : Controller
{
    [HttpGet]

    public JsonResult GetPersonals()
    {
        var Personals = personalService.GetPersonals();
        return Json(Personals);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetPersonal(long id)
    {
        var personal = personalService.GetPersonal(id);
        return Json(personal);
    }

    [Route("create")]
    [HttpPost]

    public JsonResult InsertPersonal(CreatePersonalDTO dto)
    {
        personalService.InsertPersonal(dto);

        return Json("Personal inserted");
    }

    [Route("update")]
    [HttpPatch]
    public JsonResult UpdatePersonal(UpdatePersonalDTO dto)
    {
        personalService.UpdatePersonal(dto);

        return Json("updated");
    }

    [Route("delete/{id}")]
    [HttpDelete]

    public JsonResult DeletePersonal(long id)
    {
        personalService.DeletePersonal(id);

        return Json("deleted");
    }
}