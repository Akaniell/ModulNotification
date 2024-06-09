using DTO.NotificationDTO;
using Repository.NotificationRepository;

namespace Service.NotificationService;

public class PatternService(IPatternRepository patternRepository) : IPatternService
{
    private IPatternRepository _patternRepository = patternRepository;
    
    public async Task<PatternDTO> GetPattern(long id) 
    {
        return await _patternRepository.Get(id);
    }

    public async Task<List<PatternDTO>> GetPatterns() 
    {
        return await _patternRepository.GetAll(); 
    }
}