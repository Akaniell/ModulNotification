using Data.CourseData;
using DTO.CourseDTO;

namespace Service.CourseService;
public interface IPracticeService
{
    PracticeDTO GetPractice(long Id);
    List<PracticeDTO> GetPractices();
    void InsertPractice(CreatePracticeDTO dto);
    void UpdatePractice(UpdatePracticeDTO dto);
    void DeletePractice(long Id);
}