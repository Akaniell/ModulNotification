using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.CourseRepository;

public class TheoryRepository(ApplicationContext context) : ITheoryRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Theory> _theories = context.Set<Theory>();

    public TheoryDTO Get(long id)
    {
        var theory = _theories.SingleOrDefault(e => e.Id == id);
        if (theory == null) return null;

        var TheoryDTO = new TheoryDTO
        {
            Id = theory.Id,
            Theory_field = theory.Theory_field,
            Course_ID = theory.Course_ID
        };

        return TheoryDTO;
    }

    public List<TheoryDTO> GetAll()
    {
        var theories = _theories.ToList();

        return theories.Select(theory => new TheoryDTO
        {
            Id = theory.Id,
            Theory_field = theory.Theory_field,
            Course_ID = theory.Course_ID
        }).ToList();
    }
    
    public void Insert(CreateTheoryDTO dto)
    {
        var theory = new Theory
        {
            Theory_field = dto.Theory_field,
            Course_ID = dto.Course_ID
        };
        
        _theories.Add(theory);
        context.SaveChanges();
    }

    public void Update(UpdateTheoryDTO dto)
    {
        var theory = _theories.SingleOrDefault(e => e.Id == dto.Id);
        if (theory == null) return;

        theory.Theory_field = dto.Theory_field;

        theory.Course_ID = dto.Course_ID;

        _theories.Update(theory);
        context.SaveChanges();
    }
    
    public void Delete(long id)
    {
        var theory = _theories.SingleOrDefault(e => e.Id == id);
        if (theory == null) return;

        _theories.Remove(theory);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}