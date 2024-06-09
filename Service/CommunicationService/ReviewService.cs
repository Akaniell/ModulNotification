using Data.CommunicationData;
using DTO.CommunicationDTO;
using Repository.CommunicationRepository;

namespace Service.CommunicationService;

public class ReviewService(IReviewRepository ReviewRepository) : IReviewService
{
    private IReviewRepository _reviewRepository = ReviewRepository;

    public ReviewDTO GetReview(long Id)
    {
        return _reviewRepository.Get(Id);
    }

    public List<ReviewDTO> GetReviews()
    {
        return _reviewRepository.GetAll();
    }

    public void InsertReview(CreateReviewDTO dto)
    {
        _reviewRepository.Insert(dto);
    }

    public void UpdateReview(UpdateReviewDTO dto)
    {
        _reviewRepository.Update(dto);
    }

    public void DeleteReview(long id)
    {
        _reviewRepository.Delete(id);
    }
}