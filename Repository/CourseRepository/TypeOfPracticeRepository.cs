using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.CourseRepository;

public class TypeOfPracticeRepository(ApplicationContext context) : ITypeOfPracticeRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<TypeOfPractice> _typeOfPractices = context.Set<TypeOfPractice>();

    public TypeOfPracticeDTO Get(long Id)
    {
        var typeOfPractice = _typeOfPractices.SingleOrDefault(e => e.Id ==Id);
        if (typeOfPractice == null) return null;

        var TypeOfPracticeDTO = new TypeOfPracticeDTO()
        {
            Id = typeOfPractice.Id,
            Type_of_practice_field = typeOfPractice.Type_of_practice_field
        };
        return TypeOfPracticeDTO;
    }

    public List<TypeOfPracticeDTO> GetAll()
    {
        var typeOfPractices = _typeOfPractices.ToList();
        return typeOfPractices.Select(TypeOfPractice => new TypeOfPracticeDTO
        {
            Id = TypeOfPractice.Id,
            Type_of_practice_field = TypeOfPractice.Type_of_practice_field
        }).ToList();
    }
}