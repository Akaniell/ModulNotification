using Data.CourseData;
using DTO.CourseDTO;
using Repository.CourseRepository;

namespace Service.CourseService;

public class TypeOfPracticeService(ITypeOfPracticeRepository typeOfPracticeRepository) : ITypeOfPracticeService
{
     private ITypeOfPracticeRepository _typeOfPracticeRepository = typeOfPracticeRepository;

     public TypeOfPracticeDTO GetTypeOfPractice(long Id)
     {
          return _typeOfPracticeRepository.Get(Id);
     }

     public List<TypeOfPracticeDTO> GetTypeOfPractices()
     {
          return _typeOfPracticeRepository.GetAll();
     }
}