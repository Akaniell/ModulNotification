using Data.CourseData;
using DTO.CourseDTO;

namespace Service.CourseService;

public interface ITypeOfPracticeService
{
    TypeOfPracticeDTO GetTypeOfPractice(long Id);
    List<TypeOfPracticeDTO> GetTypeOfPractices();
}