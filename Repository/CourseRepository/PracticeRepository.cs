using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.CourseRepository;

public class PracticeRepository(ApplicationContext context) : IPracticeRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Practice> _practices = context.Set<Practice>();

    public PracticeDTO Get(long id)
    {
        var practice = _practices.SingleOrDefault(e => e.Id == id);
        if (practice == null) return null;

        var PracticeDTO = new PracticeDTO()
        {
            Id = practice.Id,
            Theory_id = practice.Theory_id,
            Type_of_practice_id = practice.Type_of_practice_id,
            Practice_field = practice.Practice_field
        };
        return PracticeDTO;
    }

    public List<PracticeDTO> GetAll()
    {
        var practices = _practices.ToList();

        return practices.Select(practice => new PracticeDTO
        {
            Id = practice.Id,
            Theory_id = practice.Theory_id,
            Type_of_practice_id = practice.Type_of_practice_id,
            Practice_field = practice.Practice_field
        }).ToList();
    }

    public void Insert(CreatePracticeDTO dto)
    {
        var practice = new Practice
        {
            Theory_id = dto.Theory_id,
            Type_of_practice_id = dto.Type_of_practice_id,
            Practice_field = dto.Practice_field
        };

        _practices.Add(practice);
        context.SaveChanges();
    }

    public void Update(UpdatePracticeDTO dto)
    {
        var practice = _practices.SingleOrDefault(e => e.Id == dto.Id);
        if (practice == null) return;

        practice.Theory_id = dto.Theory_id;
        practice.Type_of_practice_id = dto.Type_of_practice_id;
        practice.Practice_field = dto.Practice_field;

        _practices.Update(practice);
        context.SaveChanges();
    }
    
    public void Delete(long id)
    {
        var practice = _practices.SingleOrDefault(e => e.Id == id);
        if (practice == null) return;

        _practices.Remove(practice);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}