using DTO.CourseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.CommunicationData;
using DTO.CommunicationDTO;

namespace Service.CommunicationService;
public interface IReviewService
{
    ReviewDTO GetReview(long Id);
    List<ReviewDTO> GetReviews();
    void InsertReview(CreateReviewDTO dto);
    void UpdateReview(UpdateReviewDTO dto);
    void DeleteReview(long Id);
}