using Data.CommunicationData;
using DTO.CommunicationDTO;
using Microsoft.AspNetCore.Mvc;
using Service.CommunicationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("forum")]

public class ForumController(IForumService forumService) : Controller
{
    [HttpGet]

    public JsonResult GetForums()
    {
        var Forums = forumService.GetForums();
        return Json(Forums);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetForum(long id)
    {
        var forum = forumService.GetForum(id);
        return Json(forum);
    }

    [Route("create")]
    [HttpPost]

    public JsonResult InsertForum(CreateForumDTO dto)
    {
        forumService.InsertForum(dto);

        return Json("Forum inserted");
    }

    [Route("update")]
    [HttpPatch]
    public JsonResult UpdateForum(UpdateForumDTO dto)
    {
        forumService.UpdateForum(dto);

        return Json("updated");
    }

    [Route("delete/{id}")]
    [HttpDelete]

    public JsonResult DeleteForum(long id)
    {
        forumService.DeleteForum(id);

        return Json("deleted");
    }

}