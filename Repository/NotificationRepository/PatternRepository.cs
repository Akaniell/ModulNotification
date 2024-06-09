using Data.NotificationData;
using DTO.NotificationDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.NotificationRepository;

public class PatternRepository(ApplicationContext context) : IPatternRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Pattern> _patterns = context.Set<Pattern>();
    
    public async Task<PatternDTO> Get(long id)
    {
        var pattern = _patterns.SingleOrDefault(e => e.Id == id);
        if (pattern == null) return await Task.FromResult<PatternDTO>(null);

        return await Task.FromResult(new PatternDTO
        {
            Id = pattern.Id,
            Name = pattern.Name,
            Default_text =pattern.Default_text
        });
    }

    public async Task<List<PatternDTO>> GetAll()
    {
        var patterns = _patterns.ToList();

        return await Task.FromResult(patterns.Select(pattern => new PatternDTO
            {
                Id = pattern.Id,
                Name = pattern.Name,
                Default_text = pattern.Default_text
            })
            .ToList());
    }
}