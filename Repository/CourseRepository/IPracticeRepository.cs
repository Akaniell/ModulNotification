using DTO.CourseDTO;

namespace Repository.CourseRepository;

public interface IPracticeRepository
{
    PracticeDTO Get(long Id);
    List<PracticeDTO> GetAll();
    void Insert(CreatePracticeDTO dto);
    void Update(UpdatePracticeDTO dto);
    void Delete(long Id);
}