using DTO.NotificationDTO;

namespace Service.NotificationService;

public interface IPatternService
{
    Task<PatternDTO> GetPattern(long id);
    Task<List<PatternDTO>> GetPatterns();
}