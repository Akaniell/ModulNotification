using DTO.NotificationDTO;

namespace Repository.NotificationRepository;

public interface IPatternRepository
{
    Task<PatternDTO> Get(long id);
    Task<List<PatternDTO>> GetAll();
}