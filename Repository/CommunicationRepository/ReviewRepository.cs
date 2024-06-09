using Data.CommunicationData;
using DTO.CommunicationDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.CommunicationRepository;

    public class ReviewRepository(ApplicationContext context) : IReviewRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Review> _reviews = context.Set<Review>();
    public ReviewDTO Get(long id)
    {
        var review = _reviews.SingleOrDefault(e => e.Id == id);
        if (review == null) return null;

        var ReviewDTO = new ReviewDTO()
        {
            Id = review.Id,
            User_id = review.User_id,
            Course_id = review.Course_id,
            Star = review.Star,
            Review_text = review.Review_text
        };
        return ReviewDTO;
    }
    public List<ReviewDTO> GetAll()
    {
        var reviews = _reviews.ToList();

        return reviews.Select(review => new ReviewDTO
        {
            Id = review.Id,
            User_id = review.User_id,
            Course_id = review.Course_id,
            Star = review.Star,
            Review_text = review.Review_text
        }).ToList();
    }
    public void Insert(CreateReviewDTO dto)
    {
        var review = new Review
        {
            User_id = dto.User_id,
            Course_id = dto.Course_id,
            Star = dto.Star,
            Review_text = dto.Review_text
        };

        _reviews.Add(review);
        context.SaveChanges();
    }
    public void Update(UpdateReviewDTO dto)
    {
        var review = _reviews.SingleOrDefault(e => e.Id == dto.Id);
        if (review == null) return;

        review.User_id = dto.User_id;
        review.Course_id = dto.Course_id;
        review.Star = dto.Star;
        review.Review_text = dto.Review_text;

        _reviews.Update(review);
        context.SaveChanges();
    }
    public void Delete(long id)
    {
        var review = _reviews.SingleOrDefault(e => e.Id == id);
        if (review == null) return;

        _reviews.Remove(review);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}