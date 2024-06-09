using Data.CommunicationData;
using DTO.CommunicationDTO;
using Microsoft.AspNetCore.Mvc;
using Service.CommunicationService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("review")]

public class ReviewController(IReviewService reviewService) : Controller
{
    [HttpGet]

    public JsonResult GetReviews()
    {
        var Reviews = reviewService.GetReviews();
        return Json(Reviews);
    }

    [Route("{id}")]
    [HttpGet]

    public JsonResult GetReview(long id)
    {
        var review = reviewService.GetReview(id);
        return Json(review);
    }

    [Route("create")]
    [HttpPost]

    public JsonResult InsertReview(CreateReviewDTO dto)
    {
        reviewService.InsertReview(dto);

        return Json("Review inserted");
    }

    [Route("update")]
    [HttpPatch]
    public JsonResult UpdateReview(UpdateReviewDTO dto)
    {
        reviewService.UpdateReview(dto);

        return Json("updated");

    }

    [Route("delete/{id}")]
    [HttpDelete]

    public JsonResult DeleteReview(long id)
    {
        reviewService.DeleteReview(id);

        return Json("deleted");
    }
}