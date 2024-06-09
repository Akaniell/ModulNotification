using DTO.CourseDTO;

namespace Repository.CourseRepository;

public interface ITypeOfPracticeRepository
{
    TypeOfPracticeDTO Get(long Id);
    List<TypeOfPracticeDTO> GetAll();
}