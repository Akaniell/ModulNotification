using Data.CourseData;
using DTO.CourseDTO;

namespace Service.CourseService;

public interface ITheoryService
{
    TheoryDTO GetTheory(long Id);
    List<TheoryDTO> GetTheories();
    void InsertTheory(CreateTheoryDTO dto);
    void UpdateTheory(UpdateTheoryDTO dto);
    void DeleteTheory(long Id);
}