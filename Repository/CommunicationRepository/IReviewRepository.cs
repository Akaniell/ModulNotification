using DTO.CommunicationDTO;

namespace Repository.CommunicationRepository
{
    public interface IReviewRepository
    {
        ReviewDTO Get(long Id);
        List<ReviewDTO> GetAll();
        void Insert(CreateReviewDTO dto);
        void Update(UpdateReviewDTO dto);
        void Delete(long Id);
    }
}