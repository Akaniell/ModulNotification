using Data.CommunicationData;
using DTO.CommunicationDTO;
using Microsoft.AspNetCore.Mvc;
using Service.CommunicationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("message")]

public class MessageController(IMessageService messageService) : Controller
{
    [HttpGet]

    public JsonResult GetMessages()
    {
        var Messages = messageService.GetMessages();
        return Json(Messages);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetMessage(long id)
    {
        var message = messageService.GetMessage(id);
        return Json(message);
    }

    [Route("create")]
    [HttpPost]

    public JsonResult InsertMessage(CreateMessageDTO dto)
    {
        messageService.InsertMessage(dto);

        return Json("Message inserted");
    }

    [Route("update")]
    [HttpPatch]
    public JsonResult UpdateMessage(UpdateMessageDTO dto)
    {
        messageService.UpdateMessage(dto);

        return Json("updated");
    }

    [Route("delete/{id}")]
    [HttpDelete]

    public JsonResult DeleteMessage(long id)
    {
        messageService.DeleteMessage(id);

        return Json("deleted");
    }
}